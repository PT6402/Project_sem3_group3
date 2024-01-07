/* eslint-disable react/prop-types */
import { UIBox } from "../../../../common";
import { Card, Divider, Grid } from "@mui/material";
import UserInformation from "./components/UserInformation";
import OrderSummary from "./components/OrderSummary";
import FrameUI from "../../../../../helpers/FrameUI";
import Header from "./components/Header";

export default function OrderDetail({ orderDetail }) {
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
  return (
    <>
      {orderDetail != null && (
        <FrameUI>
          <UIBox p={2} sx={{ width: "100%" }}>
            <Grid container spacing={3} justifyContent="center">
              <Grid item xs={12} lg={12}>
                <Card sx={{ padding: "2rem" }}>
                  <UIBox pt={2} px={2}>
                    <Header
                      order_id={orderDetail[0].orderId}
                      createDate={formatNgayThangNam(
                        orderDetail[0].createdDate
                      )}
                    />
                  </UIBox>
                  <Divider />
                  <UIBox pt={1} pb={3} px={2}>
                    <UIBox>
                      <Grid container spacing={3}>
                        <Grid item xs={12} md={6} lg={5}>
                          <UIBox>
                            <UserInformation
                              fullName={orderDetail[0].fullName}
                              phone={orderDetail[0].phone}
                              connect_type_name={orderDetail[0].connectTypeName}
                              packages={orderDetail[0].packageName}
                              time={orderDetail[0].durationTime}
                              validate={orderDetail[0].validate}
                            />
                          </UIBox>
                        </Grid>
                        <Grid item xs={12} lg={3} sx={{ ml: "auto" }}>
                          <OrderSummary
                            packagePrice={orderDetail[0].packagePrice}
                            deposit={orderDetail[0].deposit}
                            coupon={orderDetail[0].coupon}
                            tax={orderDetail[0].tax}
                            totalPrice={orderDetail[0].totalPrice}
                          />
                        </Grid>
                      </Grid>
                    </UIBox>
                  </UIBox>
                </Card>
              </Grid>
            </Grid>
          </UIBox>
        </FrameUI>
      )}
    </>
  );
}
