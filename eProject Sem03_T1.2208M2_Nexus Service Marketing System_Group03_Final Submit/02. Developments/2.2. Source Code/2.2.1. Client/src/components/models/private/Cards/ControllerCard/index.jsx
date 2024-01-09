// prop-types is a library for typechecking of props
import PropTypes from "prop-types";

// @mui material components
import Card from "@mui/material/Card";
import Switch from "@mui/material/Switch";

// Soft UI Dashboard PRO React components
import SoftBox from "components/common/SoftBox";
import SoftTypography from "components/common/SoftTypography";

function ControllerCard({ color, state, icon, title, description, onChange }) {
  return (
    <Card sx={{ height: "100%" }}>
      <SoftBox
        p={3}
        height="100%"
        bgColor={state ? color : "white"}
        variant="gradient"
        display="flex"
        flexDirection="column"
        justifyContent="space-between">
        <SoftBox
          display="flex"
          justifyContent="space-between"
          alignItems="center"
          mb={2}
          lineHeight={1}>
          <SoftTypography variant="body2" color={state ? "white" : "text"}>
            {state ? "On" : "Off"}
          </SoftTypography>
          <SoftBox mr={1}>
            <Switch checked={state} onChange={onChange} />
          </SoftBox>
        </SoftBox>
        {icon}
        <SoftBox mt={1} lineHeight={1}>
          <SoftTypography
            variant="body2"
            color={state ? "white" : "text"}
            textTransform="capitalize"
            fontWeight="medium">
            {title}
          </SoftTypography>
          {description ? (
            <SoftTypography variant="caption" color={state ? "white" : "text"}>
              {description}
            </SoftTypography>
          ) : null}
        </SoftBox>
      </SoftBox>
    </Card>
  );
}

// Setting default values for the props of ControllerCard
ControllerCard.defaultProps = {
  color: "info",
  state: false,
  description: "",
};

// Typechecking props for the ControllerCard
ControllerCard.propTypes = {
  color: PropTypes.oneOf([
    "primary",
    "secondary",
    "info",
    "success",
    "warning",
    "error",
    "dark",
  ]),
  state: PropTypes.bool,
  icon: PropTypes.node.isRequired,
  title: PropTypes.string.isRequired,
  description: PropTypes.string,
  onChange: PropTypes.func.isRequired,
};

export default ControllerCard;
