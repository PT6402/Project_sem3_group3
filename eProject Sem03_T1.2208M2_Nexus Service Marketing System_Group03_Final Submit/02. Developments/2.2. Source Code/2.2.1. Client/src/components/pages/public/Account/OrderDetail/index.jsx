/* eslint-disable react/prop-types */
import { UIBox, UIButton } from "../../../../common";
import { Card, Divider, Grid } from "@mui/material";
import UserInformation from "./components/UserInformation";
import OrderSummary from "./components/OrderSummary";
import FrameUI from "../../../../../helpers/FrameUI";
import Header from "./components/Header";
import { axiosAuthentication } from "../../../../../../http";
import { loadStripe } from "@stripe/stripe-js";
import Stripe from "stripe";
import { useRef, useState } from "react";
export default function OrderDetail({ orderDetail }) {
  const [statusFeedback, setStatusFeedback] = useState(false);
  const feedbackInput = useRef();
  const buttonFeedbackInput = useRef();
  function formatNgayThangNam(chuoiNgay) {
    let ngayGoc = new Date(chuoiNgay);
    let ngay = ngayGoc.getDate();
    let thang = ngayGoc.getMonth() + 1;
    let nam = ngayGoc.getFullYear();
    let ngayMoiFormat =
      ngay.toString().padStart(2, "0") +
      "/" +
      thang.toString().padStart(2, "0") +
      "/" +
      nam.toString();
    return ngayMoiFormat;
  }
  async function initializeStripe(pubKey) {
    const stripe = await loadStripe(pubKey);
    return stripe;
  }
  async function checkout({ pubKey, sessionId }) {
    const stripe = await initializeStripe(pubKey);
    stripe.redirectToCheckout({ sessionId });
  }
  const handlePayment = async (orderId) => {
    localStorage.setItem("back_page", "/account");
    const url = `http://localhost:8000/api/Stripe/${orderId}`;
    await axiosAuthentication.get(url).then(async (res) => {
      if (res.status == 200) {
        const sessionId = res.data.sessionId;
        const pubKey =
          "pk_test_51OVfTBDuw2SA7iQX2LFfEOYc6Mz6OSDsMd9llazwmTzEPt9KdQc0QFotbVqPi6P9qKiGmnNDQXbmqAPkXSOZD8VW00upFCUZ4K";
        await checkout({ pubKey, sessionId }).then((res) => console.log(res));
        return;
      }
    });
  };
  const handleClickChangeStatus = () => {
    if (
      feedbackInput.current?.value == " " ||
      feedbackInput.current?.value == null
    ) {
      setStatusFeedback((prev) => !prev);
    } else {
      setStatusFeedback(false);
      buttonFeedbackInput.current.disabled;
    }
    // console.log(feedbackInput.current.value);
  };
  return (
    <>
      {orderDetail != null && (
        <FrameUI>
          <UIBox p={2} sx={{ width: "100%" }}>
            <Grid container spacing={3} justifyContent="center">
              {orderDetail.map((item, index) => (
                <Grid item xs={12} lg={12} key={index}>
                  <Card sx={{ padding: "2rem" }}>
                    <UIBox pt={2} px={2}>
                      <Header
                        order_id={item.orderId}
                        createDate={formatNgayThangNam(item.createdDate)}
                        status={item.status}
                        handlePayment={handlePayment}
                      />
                    </UIBox>
                    <Divider />
                    <UIBox pt={1} pb={3} px={2}>
                      <UIBox>
                        <Grid container spacing={3}>
                          <Grid item xs={12} md={6} lg={5}>
                            <UIBox>
                              <UserInformation
                                fullName={item.fullName}
                                phone={item.phone}
                                connect_type_name={item.connectTypeName}
                                packages={item.packageName}
                                time={item.durationTime}
                                validate={item.validate}
                              />
                            </UIBox>
                          </Grid>
                          <Grid item xs={12} lg={3} sx={{ ml: "auto" }}>
                            <OrderSummary
                              packagePrice={item.packagePrice}
                              deposit={item.deposit}
                              coupon={item.coupon}
                              tax={item.tax}
                              totalPrice={item.totalPrice}
                            />
                            {item.status == "Paid" && (
                              <UIButton
                                color="success"
                                variant={
                                  statusFeedback ? "contained" : "outlined"
                                }
                                ref={buttonFeedbackInput}
                                sx={{
                                  margin: "1rem 0",
                                  padding: "1rem 5rem",
                                  whiteSpace: "nowrap",
                                  width: "100%",
                                }}
                                onClick={handleClickChangeStatus}>
                                {statusFeedback ? "Send" : "Feed back"}
                              </UIButton>
                            )}
                          </Grid>
                        </Grid>
                      </UIBox>
                      {statusFeedback && (
                        <>
                          <Divider />
                          <UIBox pb={3} px={2} sx={{ width: "100%" }}>
                            <UIBox sx={{ width: "100%" }}>
                              <textarea
                                style={{
                                  width: "100%",
                                  height: "100px",
                                  border: ".1rem solid #000",
                                  borderRadius: "1rem",
                                  padding: "1rem",
                                }}
                                placeholder="enter feedback..."
                                ref={feedbackInput}></textarea>
                            </UIBox>
                          </UIBox>
                        </>
                      )}
                    </UIBox>
                  </Card>
                </Grid>
              ))}
            </Grid>
          </UIBox>
        </FrameUI>
      )}
    </>
  );
}
