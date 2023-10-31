import { AppBar, Toolbar, Typography, Box, Tooltip } from "@mui/material";
import { Link } from "react-router-dom";
import Logo from "./Logo";
import "../index.css";

import { IconButton, MenuItem, Menu, Avatar } from "@mui/material";
// import { useState } from "react";

function MyAppBar() {
  /* 
  **TO DO: AUTHENTIFICATION**
  **Coded out section is for user profile when authentification is later added in **
  
  const settings = ["Profile", "Account", "Dashboard", "Logout"];
  const [anchorElUser, setAnchorElUser] = React.useState<null | HTMLElement>(
    null
    );
    
    const handleOpenUserMenu = (event: React.MouseEvent<HTMLElement>) => {
      setAnchorElUser(event.currentTarget);
    };
    
    const handleCloseUserMenu = () => {
      setAnchorElUser(null);
    };
    */

  return (
    <div>
      <AppBar
        sx={{
          bgcolor: "rgba(150, 168, 131, .25)",
          boxShadow: "none",
        }}
        position="fixed"
      >
        <Toolbar>
          <Link to="/">
            <Box
              sx={{
                display: "flex",
                flexDirection: "row",
                flexGrow: 1,
                alignItems: "center",
              }}
            >
              <Logo />
              <Typography
                variant="h4"
                component="a"
                href="/"
                sx={{
                  mr: 2,
                  width: "50%",
                  color: "black",
                  letterSpacing: "normal",
                  textDecoration: "none",
                }}
              >
                Nature's Home
              </Typography>
            </Box>
          </Link>

          <Box sx={{ display: "flex", justifyContent: "center", flexGrow: 1 }}>
            <Link to="/garden">
              <Typography
                variant="h5"
                noWrap
                component="a"
                href="/garden"
                sx={{
                  mr: 2,
                  color: "black",
                  letterSpacing: ".2rem",
                  textDecoration: "none",
                }}
              >
                Garden
              </Typography>
            </Link>
            <Link to="/plants">
              <Typography
                variant="h5"
                noWrap
                component="a"
                href="/plants"
                sx={{
                  mr: 2,
                  color: "black",
                  font: "bold",
                  letterSpacing: ".2rem",
                  textDecoration: "none",
                }}
              >
                Plants
              </Typography>
            </Link>
            <Link to="/ailments">
              <Typography
                variant="h5"
                noWrap
                component="a"
                href="/ailments"
                sx={{
                  mr: 2,
                  color: "black",
                  letterSpacing: ".2rem",
                  textDecoration: "none",
                }}
              >
                Ailments
              </Typography>
            </Link>
            <Link to="/remains">
              <Typography
                variant="h5"
                noWrap
                component="a"
                href="/remains"
                sx={{
                  mr: 2,
                  color: "black",
                  letterSpacing: ".2rem",
                  textDecoration: "none",
                }}
              >
                To Do's
              </Typography>
            </Link>
            <Link to="/*">
              <Typography
                variant="h5"
                noWrap
                component="a"
                href="/*"
                sx={{
                  mr: 2,
                  color: "black",
                  letterSpacing: ".2rem",
                  textDecoration: "none",
                }}
              ></Typography>
            </Link>
          </Box>

          <Box sx={{ flexGrow: 1 }}>
            <Tooltip title="Open settings">
              <IconButton sx={{ p: 1 }}>
                <Avatar />
              </IconButton>
            </Tooltip>

            {/* TO DO: AUTHENTIFICATION
            
            <Tooltip title="Open settings">
              <IconButton onClick={handleOpenUserMenu} sx={{ p: 0 }}>
                <Avatar />
              </IconButton>
            </Tooltip>
            <Menu
              sx={{ mt: "45px" }}
              id="menu-appbar"
              anchorEl={anchorElUser}
              anchorOrigin={{
                vertical: "top",
                horizontal: "right",
              }}
              keepMounted
              transformOrigin={{
                vertical: "top",
                horizontal: "right",
              }}
              open={Boolean(anchorElUser)}
              onClose={handleCloseUserMenu}
            >
              {settings.map((setting) => (
                <MenuItem key={setting} onClick={handleCloseUserMenu}>
                  <Typography textAlign="center">{setting}</Typography>
                </MenuItem>
              ))}
            </Menu> */}
          </Box>
        </Toolbar>
      </AppBar>
    </div>
  );
}

export default MyAppBar;
