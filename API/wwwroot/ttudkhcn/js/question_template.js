function GetListQuestion(MaDV, TenDV) {
    var userMessage = "<div class='card-body-message-from-admin'>" +
        "<div class='row'>" +
        "<div class='col-12'>" +
        "<span class='btn btn-primary m-1 message float-end animate__animated animate__slideInUp'>" +
        "<h6>" + TenDV + "</h6>" +
        "</span></div></div></div>";
    $("#conversation").append(userMessage); //doan nay chay ok r

    $("#conversation").animate({ scrollTop: $("#conversation").scrollTop() }, 1000);

    var adminMessage = "";

    return $.ajax({
        type: "POST",
        url: "/QuestionTemplate/GetListQuestionByService?MaDV=" + MaDV,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            console.log(data);
            if (data.listItems.length > 0) {
                for (var i = 0; i < data.listItems.length; i++) {
                    adminMessage += "<div class='card-body-message-from-admin'>" +
                        "<div class='row'>" +
                        "<div class='col-8'>" +
                        `<button class='btn btn-secondary m-1 message animate__animated animate__slideInUp' onclick='GetTheAnswer("` + data.listItems[i].question + `", "` + data.listItems[i].answer + `")'>` +
                        "<h6>" + data.listItems[i].question + "</h6>" +
                        "</button>" +
                        "</div>" +
                        "</div>" +
                        "</div>";
                }
            } else {
                adminMessage = "<div class='card-body-message-from-admin'>" +
                    "<div class='row'>" +
                    "<div class='col-8'>" +
                    `<button class='btn btn-secondary m-1 message animate__animated animate__slideInUp'>` +
                    "<h6>Opps! Không có kết quả!</h6>" +
                    "</button>" +
                    "</div>" +
                    "</div>" +
                    "</div>";
            }
            setTimeout(function () {
                $("#conversation").append(adminMessage)
            }, 1500);

            $("#conversation").animate({ scrollTop: $("#conversation").scrollTop() }, 1000);
        },
        error: function () {
            console.log("err");
        }
    });
};

function GetTheAnswer(TenCauHoi, CauTraLoi) {
    var userMessage = "<div class='card-body-message-from-admin'>" +
        "<div class='row'>" +
        "<div class='col-12'>" +
        "<span class='btn btn-primary m-1 message float-end animate__animated animate__slideInUp'>" +
        "<h6>" + TenCauHoi + "</h6>" +
        "</span></div></div></div>";

    $("#conversation").append(userMessage);

    $("#conversation").animate({ scrollTop: $("#conversation").scrollTop() }, 1000);

    var adminMessage = "<div class='card-body-message-from-admin'>" +
        "<div class='row'>" +
        "<div class='col-8'>" +
        "<span class='btn btn-secondary m-1 message animate__animated animate__slideInUp'>" +
        "<h6>" + CauTraLoi + "</h6>" +
        "</span>" +
        "</div>" +
        "</div>" +
        "</div>";
    setTimeout(function () {
        $("#conversation").append(adminMessage)
    }, 1500);

    $("#conversation").animate({ scrollTop: $("#conversation").scrollTop() }, 1000);

};

setTimeout(function () {
    localStorage.removeItem("Opened");
}, 3600000);

function openCanvas() {
    var offcanvas = document.getElementById("QuestionTemPlate");
    setTimeout(function () {
        var opened = localStorage.getItem("Opened");
        console.log(opened);
        if (opened == null || opened == 1) {
            var bsOffcanvas = new bootstrap.Offcanvas(offcanvas);
            bsOffcanvas.show();
            localStorage.setItem("Opened", 0);
        }
    }, 10000);
}

openCanvas();

$(document).ready(function () {
    $("#guiCauHoi").click(function () {
        var SoDT = $("#sodtcauhoi").val();
        var CauHoi = $("#cauhoi").val();
        var HoTen = $("#hotencauhoi").val();

        return $.ajax({
            type: "POST",
            url: "/QuestionTemplate/SendMessage?HoTen=" + HoTen + "&SoDT=" + SoDT + "&CauHoi=" + CauHoi,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                $("#txtErr").html("<div class='alert alert-danger'>" + data.msg + "</div>");
            },
            error: function () {
                console.log("err");
            }
        });
    });
});