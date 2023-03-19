// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
  // if not in login page, check if user is logged in
  if (window.location.pathname !== "/login")
  {
    if (!localStorage.getItem("jwtToken")) {
      window.location.href = "/login";
    }
  }
});
