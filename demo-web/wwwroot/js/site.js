// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    
});
var valu = $('#soNguyen4').val();
$('select option').each(function (select) {
    if ($(this).val() == valu) {
        $(this).attr("selected", "selected")
    }
})


