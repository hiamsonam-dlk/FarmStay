$("#traCuuBtn").click(function () {
    $("#ajaxLoader").show();
    var MaKH = $("#txtMaKH").val();
    var KyThanhToan = "";
    if (MaKH == null || MaKH <= 0) {
        $("#txtErr").html("<div class='alert alert-danger'>Vui lòng nhập mã khách hàng!</div>");
        $("#ajaxLoader").hide();
    }
    else {
        return $.ajax({
            type: "POST",
            url: "/TraCuu/TraCuuHoaDonVT?MaKH=" + MaKH + "&KyThanhToan=" + KyThanhToan,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data.error_message)
                if (data.error_code == "00") {
                    $("#tenKHTraCuu").val(data.data[0].customer_name);
                    $("#sdtKHTraCuu").val(data.data[0].customer_tax_reg_no);
                    $("#diaChiKHTraCuu").val(data.data[0].customer_address);
                    $("#chiSoCu").val(data.data[0].details[0].new_index);
                    $("#txtErr").html("<div class='alert alert-success'><i class='fa fa-check' aria-hidden='true'></i> Thành công!</div>");
                }
                else {
                    $("#txtErr").html("<div class='alert alert-danger'><i class='fa fa-exclamation-circle' aria-hidden='true'></i> Lỗi: " + data.error_message + "!</div>");
                }
                $("#ajaxLoader").hide();
            },
            error: function () {
                console.log("err")
                $("#ajaxLoader").hide();
            }
        });
    }
});