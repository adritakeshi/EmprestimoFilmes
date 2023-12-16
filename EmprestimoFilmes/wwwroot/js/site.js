// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


new DataTable('#example');

setTimeout(function () {
    $(".alert").fadeout("slow", function () {
        $(this).alert("close");
    })
}, 5000)
