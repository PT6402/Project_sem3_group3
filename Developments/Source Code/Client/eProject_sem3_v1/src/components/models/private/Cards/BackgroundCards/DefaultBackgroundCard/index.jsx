// react-router-dom components/common
import { Link } from "react-router-dom";

// prop-types is a library for typechecking of props
import PropTypes from "prop-types";

// @mui material components/common
import Card from "@mui/material/Card";
import MuiLink from "@mui/material/Link";

// Soft UI Dashboard PRO React components/common
import SoftBox from "components/common/SoftBox";
import SoftTypography from "components/common/SoftTypography";
import SoftBadge from "components/common/SoftBadge";

function DefaultBackgroundCard({
  color,
  image,
  title,
  description,
  badge,
  action,
}) {
  const template = (
    <Card
      sx={({
        functions: { rgba, linearGradient },
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
        backgroundPosition: "center",
        borderRadius: borderRadius.lg,
      })}>
      <SoftBox textAlign="center" py={20} px={3} lineHeight={1}>
        <SoftTypography
          variant="h2"
          fontWeight="bold"
          color="white"
          gutterBottom>
          {title}
        </SoftTypography>
        <SoftBox mb={3}>
          <SoftTypography variant="body2" color="white">
            {description}
          </SoftTypography>
        </SoftBox>
        {badge && (
          <SoftBadge
            variant="contained"
            color="light"
            badgeContent={badge}
            container
          />
        )}
      </SoftBox>
    </Card>
  );

  return action.type === "external" ? (
    <MuiLink href={action.route} target="_blank" rel="noreferrer">
      {template}
    </MuiLink>
  ) : (
    <Link to={action.route}>{template}</Link>
  );
}

// Setting default values for the props of DefaultBackgroundCard
DefaultBackgroundCard.defaultProps = {
  color: "dark",
  badge: "",
  action: false,
};

// Typechecking props for the DefaultBackgroundCard
DefaultBackgroundCard.propTypes = {
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
  badge: PropTypes.string,
  action: PropTypes.oneOfType([
    PropTypes.shape({
      type: PropTypes.oneOf(["external", "internal"]).isRequired,
      route: PropTypes.string.isRequired,
    }),
    PropTypes.bool,
  ]),
};

export default DefaultBackgroundCard;
