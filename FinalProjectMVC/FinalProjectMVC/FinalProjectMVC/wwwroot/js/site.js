// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.getElementById("myBtn").addEventListener("click", myFunction);

if (User.IsInRole("Admin")) {
    function myFunction() {
        alert("Welcome Admin!");
    }
}

else {
    function myFunction() {
        alert("You are being redirected, to Login!");
    }
}
