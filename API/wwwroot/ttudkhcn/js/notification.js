$(document).ready(function () {
    $("#notification").modal('show');
    $("#closeNotification").click(function () {
        $("#notification").modal('hide');
        console.log("ok");
        /*document.location.href = "/";*/
    });
});