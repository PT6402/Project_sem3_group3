import React from "react";
import { UIBox, UITypography } from "../../../common";
import curved0 from "assets/images/private/curved-images/curved0.jpg";
import { Card, Grid } from "@mui/material";
export default function Header() {
  return (
    <UIBox position="relative">
      <UIBox
        display="flex"
        alignItems="center"
        position="relative"
        minHeight="20.75rem"
        borderRadius="xxl"
        sx={{
          backgroundImage: ({
            functions: { rgba, linearGradient },
            palette: { gradients },
          }) =>
            `${linearGradient(
              rgba(gradients.info.main, 0.6),
              rgba(gradients.info.state, 0.6)
            )}, url(${curved0})`,
          backgroundSize: "cover",
          backgroundPosition: "50%",
          overflow: "hidden",
        }}
      />
      <Card
        sx={{
          backdropFilter: `saturate(200%) blur(60px)`,
          backgroundColor: ({ functions: { rgba }, palette: { white } }) =>
            rgba(white.main, 0.8),
          boxShadow: ({ boxShadows: { navbarBoxShadow } }) => navbarBoxShadow,
          position: "relative",
          mt: -7,
          mx: 3,
          py: 3,
          px: 2,
        }}>
        <Grid
          container
          spacing={3}
          alignItems="center"
          justifyContent={"center"}>
          <Grid item>
            <UIBox height="100%" mt={0.5} lineHeight={1}>
              <UITypography variant="h2" fontWeight="bold">
                About Us
              </UITypography>
            </UIBox>
          </Grid>
        </Grid>
      </Card>
    </UIBox>
  );
}
