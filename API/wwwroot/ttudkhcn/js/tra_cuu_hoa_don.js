$(document).ready(function () {
    //$("#staticBackdrop").modal('show');

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

    $("#layTTNayBtn").click(function () {
        var maKHADTT = $("#txtMaKH").val();
        var tenKHCuADTT = $("#tenKHTraCuu").val();
        var diaChiKHCuADTT = $("#diaChiKHTraCuu").val();
        var sdtKHCuADTT = $("#sdtKHTraCuu").val();
        var chiSoCu = $("#chiSoCu").val();
        $("#maKHADTT").val(maKHADTT);
        $("#tenKHCuADTT").val(tenKHCuADTT);
        $("#diaChiKHCuADTT").val(diaChiKHCuADTT);
        $("#sdtKHCuADTT").val(sdtKHCuADTT);
        $("#tenKHMoi").val(tenKHCuADTT);
        $("#diaChiKHMoi").val(diaChiKHCuADTT);
        $("#sdtKHMoi").val(sdtKHCuADTT);
        $("#chiSoCu_SauTraCuu").val(chiSoCu);
    })

    $("#closeTraCuu").click(function () {
        $("#staticBackdrop").modal('hide');
    })

    $("#traCuuHDVTBtn").click(function () {
        var MaKH = $("#txtMaKH").val();
        var KyThanhToanTuThang = $("#KyHienTaiTuThang").val();
        var KyThanhToanDenThang = $("#KyHienTaiDenThang").val();
        var KyThanhToanTuNam = $("#KyHienTaiTuNam").val();
        var KyThanhToanDenNam = $("#KyHienTaiDenNam").val();
        var str = ""
        if (MaKH == null || MaKH <= 0) {
            $("#txtErr").html("<div class='alert alert-danger'>Vui lòng nhập mã khách hàng!</div>");
        }
        else {
            $("#ajaxLoader").show();
            return $.ajax({
                type: "POST",
                url: "/TraCuu/TraCuuHoaDonVT?MaKH=" + MaKH + "&TuThang=" + KyThanhToanTuThang + "&TuNam=" + KyThanhToanTuNam + "&DenThang=" + KyThanhToanDenThang + "&DenNam=" + KyThanhToanDenNam,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    console.log(data)
                    if (data.error_code == "00") {
                        $("#txtErr").html("<div class='alert alert-success'><i class='fa fa-check' aria-hidden='true'></i> Thành công!</div>");

                        var array = data.data[0].details;
                        var seenNames = {};
                        array = array.filter(function (current) {
                            if (current.period_no in seenNames) {
                                return false;
                            } else {
                                seenNames[current.period_no] = true;
                                return true;
                            }
                        });

                        array.sort(function (x, y) {
                            if (x.period_no > y.period_no) {
                                return -1;
                            }
                            if (x.period_no < y.period_no) {
                                return 1;
                            }
                            return 0;
                        });

                        data.data[0].details = array; 

                        //str += "<tr><th class='col-header'>Tên KH</th><td class='e-cell'>" + data.data[0].customer_name + "</td></tr>" +
                        //    "<tr><th class='col-header'>Mã KH</th><td class='e-cell'>" + data.data[0].customer_code + "</td></tr>" +
                        //    "<tr><th class='col-header'>Địa chỉ KH</th><td class='e-cell'>" + data.data[0].customer_address + "</td></tr>" +
                        //    "<tr><th class='col-header'>Kỳ HĐ</th><td class='e-cell'>" + data.data[0].details[0].period_no + "</td></tr>" +
                        //    "<tr><th class='col-header'>CSC</th><td class='e-cell'>" + data.data[0].details[0].old_index + "</td></tr>" +
                        //    "<tr><th class='col-header'>CSM</th><td class='e-cell'>" + data.data[0].details[0].new_index + "</td></tr>" +
                        //    "<tr><th class='col-header'>KLTT</th><td class='e-cell'>" + data.data[0].details[0].quantity + "</td></tr>" +
                        //    "<tr><th class='col-header'>Tổng tiền</th><td class='e-cell'>" + data.data[0].details[0].amount + "</td></tr>" +
                        //    "<tr><th class='col-header'>Trạng thái</th><td class='e-cell'>" + data.data[0].details[0].payment_status + "</td></tr>" +
                        //    `<tr><th class="col-header"><a class="btn btn-primary" href="/TraCuu/TaiFilePDF?invoiceno=` + data.data[0].details[0].einvoice_no + `">Tải file PDF <i class="fa fa-download" aria-hidden="true"></i></a></th>` +
                        //    `<th class="col-header"><a class="btn btn-primary" href="/TraCuu/TaiFileXML?invoiceno=` + data.data[0].details[0].einvoice_no + `">Tải file XML <i class="fa fa-download" aria-hidden="true"></i></a></th></tr>`;
                        for (var i = 0; i < data.data[0].details.length; i++) {
                            str += "<tr><td class='e-cell'>" + data.data[0].customer_code + "</td > " +
                                "<td class='e-cell'>" + data.data[0].customer_name + "</td>" +
                                "<td class='e-cell'>" + data.data[0].customer_address + "</td>" +
                                "<td class='e-cell'>" + data.data[0].details[i].period_no + "</td>" +
                                "<td class='e-cell'>" + data.data[0].details[i].old_index + "</td>" +
                                "<td class='e-cell'>" + data.data[0].details[i].new_index + "</td>" +
                                "<td class='e-cell'>" + data.data[0].details[i].quantity + "</td>" +
                                "<td class='e-cell'>" + data.data[0].details[i].amount + "</td>" +
                                "<td class='e-cell'>" + data.data[0].details[i].payment_status + "</td>" +
                                `<th class="col-header"><a class="btn btn-primary" href="/TraCuu/TaiFilePDF?invoiceno=` + data.data[0].details[0].einvoice_no + `">Tải file PDF <i class="fa fa - download" aria-hidden="true"></i></a></th>` +
                                `<th class="col-header"><a class="btn btn-primary" href="/TraCuu/TaiFileXML?invoiceno=` + data.data[0].details[0].einvoice_no + `">Tải file XML <i class="fa fa-download" aria-hidden="true"></i></a></th></tr>`;
                        }

                        $("#dataResponse").html(str);
                    }
                    else {
                        $("#txtErr").html("<div class='alert alert-danger'><i class='fa fa-exclamation-circle' aria-hidden='true'></i> Lỗi: " + data.error_message + "!</div>");
                        console.log(data.error_code)
                        str += "<tr>" +
                            "<td class='e-cell' col-span='9'>" + "Không có dữ liệu!" + "</td>" +
                            "</tr>";
                        $("#dataResponse").html(str);
                    }
                    $("#ajaxLoader").hide();
                },
                error: function () {
                    console.log("err")
                    $("#ajaxLoader").hide();
                }
            });
        }
    })


    $("#traCuuHDVNPTBtn").click(function () {
        var MaKH = $("#txtMaKH").val();
        var KyThanhToanTuThang = $("#KyHienTaiTuThang").val();
        var KyThanhToanDenThang = $("#KyHienTaiDenThang").val();
        var KyThanhToanTuNam = $("#KyHienTaiTuNam").val();
        var KyThanhToanDenNam = $("#KyHienTaiDenNam").val();
        var str = ""
        if (MaKH == null || MaKH <= 0) {
            $("#txtErr").html("<div class='alert alert-danger'>Vui lòng nhập mã khách hàng!</div>");
        }
        else {
            $("#ajaxLoader").show();
            return $.ajax({
                type: "POST",
                url: "/TraCuu/TraCuuHoaDonVNPT?MaKH=" + MaKH + "&TuThang=" + KyThanhToanTuThang + "&TuNam=" + KyThanhToanTuNam + "&DenThang=" + KyThanhToanDenThang + "&DenNam=" + KyThanhToanDenNam,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    console.log(data)
                    if (data != null) {
                        $("#txtErr").html("<div class='alert alert-success'><i class='fa fa-check' aria-hidden='true'></i> Thành công!</div>");

                        for (var i = 0; i < data.data.length; i++) {
                            if (data.data[i] != null) {
                                for (var j = 0; j < data.data[i].listItem.length; j++) {
                                    str += "<tr><td class='e-cell'>" + data.data[i].listItem[j].cusCode + "</td > " +
                                        "<td class='e-cell'>" + data.data[i].listItem[j].cusname + "</td>" +
                                        "<td class='e-cell'> Tháng " + data.data[i].listItem[j].index + "</td>" +
                                        "<td class='e-cell'>" + data.data[i].listItem[j].publishDate + "</td>" +
                                        //"<td class='e-cell'>" + data.data[i].details[i].old_index + "</td>" +
                                        //"<td class='e-cell'>" + data.data[i].details[i].new_index + "</td>" +
                                        //"<td class='e-cell'>" + data.data[i].details[i].quantity + "</td>" +
                                        //"<td class='e-cell'>" + data.data[i].details[i].amount + "</td>" +
                                        //"<td class='e-cell'>" + data.data[i].details[i].payment_status + "</td>" +
                                        `<th class="col-header"><a class="btn btn-primary" target="_blank" href="/TraCuu/XemHoaDonVNPT?invToken=` + data.data[i].listItem[j].invToken + `">Xem hóa đơn <i class="fa fa-eye" aria-hidden="true"></i></a></th>` +
                                        `<th class="col-header"><a class="btn btn-primary" target="_blank" href="/TraCuu/XemHoaDonChuyenDoiVNPT?invToken=` + data.data[i].listItem[j].invToken + `">Xem hóa đơn chuyển đổi <i class="fa fa-eye" aria-hidden="true"></i></a></th>` +
                                        `<th class="col-header"><a class="btn btn-primary" href="/TraCuu/TaiFilePDFVNPT?invToken=` + data.data[i].listItem[j].invToken + `">Tải file PDF <i class="fa fa-download" aria-hidden="true"></i></a></th>` +
                                        `<th class="col-header"><a class="btn btn-primary" href="/TraCuu/TaiFileXMLVNPT?invToken=` + data.data[i].listItem[j].invToken + `">Tải file XML <i class="fa fa-download" aria-hidden="true"></i></a></th></tr>`;
                                        
                                }
                            }
                        }


                        //var array = data.data[0].details;
                        //var seenNames = {};
                        //array = array.filter(function (current) {
                        //    if (current.period_no in seenNames) {
                        //        return false;
                        //    } else {
                        //        seenNames[current.period_no] = true;
                        //        return true;
                        //    }
                        //});

                        //array.sort(function (x, y) {
                        //    if (x.period_no > y.period_no) {
                        //        return -1;
                        //    }
                        //    if (x.period_no < y.period_no) {
                        //        return 1;
                        //    }
                        //    return 0;
                        //});

                        //data.data[0].details = array;

                        //str += "<tr><th class='col-header'>Tên KH</th><td class='e-cell'>" + data.data[0].customer_name + "</td></tr>" +
                        //    "<tr><th class='col-header'>Mã KH</th><td class='e-cell'>" + data.data[0].customer_code + "</td></tr>" +
                        //    "<tr><th class='col-header'>Địa chỉ KH</th><td class='e-cell'>" + data.data[0].customer_address + "</td></tr>" +
                        //    "<tr><th class='col-header'>Kỳ HĐ</th><td class='e-cell'>" + data.data[0].details[0].period_no + "</td></tr>" +
                        //    "<tr><th class='col-header'>CSC</th><td class='e-cell'>" + data.data[0].details[0].old_index + "</td></tr>" +
                        //    "<tr><th class='col-header'>CSM</th><td class='e-cell'>" + data.data[0].details[0].new_index + "</td></tr>" +
                        //    "<tr><th class='col-header'>KLTT</th><td class='e-cell'>" + data.data[0].details[0].quantity + "</td></tr>" +
                        //    "<tr><th class='col-header'>Tổng tiền</th><td class='e-cell'>" + data.data[0].details[0].amount + "</td></tr>" +
                        //    "<tr><th class='col-header'>Trạng thái</th><td class='e-cell'>" + data.data[0].details[0].payment_status + "</td></tr>" +
                        //    `<tr><th class="col-header"><a class="btn btn-primary" href="/TraCuu/TaiFilePDF?invoiceno=` + data.data[0].details[0].einvoice_no + `">Tải file PDF <i class="fa fa-download" aria-hidden="true"></i></a></th>` +
                        //    `<th class="col-header"><a class="btn btn-primary" href="/TraCuu/TaiFileXML?invoiceno=` + data.data[0].details[0].einvoice_no + `">Tải file XML <i class="fa fa-download" aria-hidden="true"></i></a></th></tr>`;
                        //for (var i = 0; i < data.data[0].details.length; i++) {
                        //    str += "<tr><td class='e-cell'>" + data.data[0].customer_code + "</td > " +
                        //        "<td class='e-cell'>" + data.data[0].customer_name + "</td>" +
                        //        "<td class='e-cell'>" + data.data[0].customer_address + "</td>" +
                        //        "<td class='e-cell'>" + data.data[0].details[i].period_no + "</td>" +
                        //        "<td class='e-cell'>" + data.data[0].details[i].old_index + "</td>" +
                        //        "<td class='e-cell'>" + data.data[0].details[i].new_index + "</td>" +
                        //        "<td class='e-cell'>" + data.data[0].details[i].quantity + "</td>" +
                        //        "<td class='e-cell'>" + data.data[0].details[i].amount + "</td>" +
                        //        "<td class='e-cell'>" + data.data[0].details[i].payment_status + "</td>" +
                        //        `<th class="col-header"><a class="btn btn-primary" href="/TraCuu/TaiFilePDF?invoiceno=` + data.data[0].details[0].einvoice_no + `">Tải file PDF <i class="fa fa - download" aria-hidden="true"></i></a></th>` +
                        //        `<th class="col-header"><a class="btn btn-primary" href="/TraCuu/TaiFileXML?invoiceno=` + data.data[0].details[0].einvoice_no + `">Tải file XML <i class="fa fa-download" aria-hidden="true"></i></a></th></tr>`;
                        //}

                        $("#dataResponse").html(str);
                    }
                    else {
                        $("#txtErr").html("<div class='alert alert-danger'><i class='fa fa-exclamation-circle' aria-hidden='true'></i> Lỗi: " + data.error_message + "!</div>");
                        console.log(data.error_code)
                        str += "<tr>" +
                            "<td class='e-cell' col-span='9'>" + "Không có dữ liệu!" + "</td>" +
                            "</tr>";
                        $("#dataResponse").html(str);
                    }
                    $("#ajaxLoader").hide();
                },
                error: function () {
                    console.log("err")
                    $("#ajaxLoader").hide();
                }
            });
        }
    })
});
