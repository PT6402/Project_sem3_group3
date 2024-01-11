// react-router-dom components/common
import { Link } from "react-router-dom";

// prop-types is a library for typechecking of props
import PropTypes from "prop-types";

// @mui material components/common
import Card from "@mui/material/Card";
import Icon from "@mui/material/Icon";

// Soft UI Dashboard PRO React components/common
import SoftBox from "components/common/SoftBox";
import SoftTypography from "components/common/SoftTypography";
import SoftButton from "components/common/SoftButton";

function BackgroundBlogCard({ color, image, title, description, action }) {
  return (
    <Card raised sx={{ p: 2 }}>
      <SoftBox
        sx={({
          functions: { linearGradient, rgba },
          palette: { gradients },
          borders: { borderRadius },
        }) => ({
          backgroundImage: gradients[color]
            ? `${linearGradient(
                rgba(gradients[color].main, 0.8),
                rgba(gradients[color].state, 0.8)
              )}, url(${image})`
            : `${linearGradient(
                rgba(gradients.dark.main, 0.8),
                rgba(gradients.dark.state, 0.8)
              )}, url(${image})`,
          backgroundSize: "cover",
          borderRadius: borderRadius.lg,
          p: 2,
        })}>
        <SoftBox mb={2}>
          <SoftTypography
            variant="h6"
            color="white"
            fontWeight="bold"
            textTransform="capitalize">
            {title}
          </SoftTypography>
        </SoftBox>
        <SoftBox mb={2}>
          <SoftTypography variant="body2" color="white">
            {description}
          </SoftTypography>
        </SoftBox>
        {action.type === "internal" ? (
          <SoftButton
            component={Link}
            to={action.route}
            variant="outlined"
            color="white"
            circular>
            {action.label} &nbsp; <Icon>arrow_forward</Icon>
          </SoftButton>
        ) : (
          <SoftButton
            component="a"
            href={action.route}
            target="_blank"
            rel="noreferrer"
            variant="outlined"
            color="white"
            circular>
            {action.label} &nbsp; <Icon>arrow_forward</Icon>
          </SoftButton>
        )}
      </SoftBox>
    </Card>
  );
}

// Setting default values for the props of BackgroundBlogCard
BackgroundBlogCard.defaultProps = {
  color: "dark",
};

// Typechecking props for the BackgroundBlogCard
BackgroundBlogCard.propTypes = {
  color: PropTypes.oneOf([
    "primary",
    "secondary",
    "info",
    "success",
    "warning",
    "error",
    "dark",
  ]),
  image: PropTypes.string.isRequired,
  title: PropTypes.string.isRequired,
  description: PropTypes.node.isRequired,
  action: PropTypes.shape({
    type: PropTypes.oneOf(["external", "internal"]).isRequired,
    route: PropTypes.string.isRequired,
    label: PropTypes.string.isRequired,
  }).isRequired,
};

export default BackgroundBlogCard;
