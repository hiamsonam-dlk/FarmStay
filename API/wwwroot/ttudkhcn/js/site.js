jQuery(document).ready(function ($) {
    //Menu
    //jQuery('.stellarnav').stellarNav({
    //    theme: 'light',
    //    breakpoint: 991,
    //    position: 'right',
    //});


    // Link liên kết
    $('#BannerId').on('change', function () {
        var url = $(this).val();
        if (url) {
            window.open(url, '_blank');
        }
        return false;
    });

    //Thống kê truy cập
    $(document).ready(function () {

      

        $(".ttcnBox .f-level a").click(function () {
            var stt = $(this).attr("aria-expanded");
            if (stt == "false")
                $(this).addClass("activeMN");
            else
                $(this).removeClass("activeMN");

         
        });

       //----Leftmenu
       
        $(".leftmenu .closemn").click(function (e) {
            e.stopPropagation();
            jQuery(this).parent().children('.childmenu').slideToggle(200);
            jQuery(this).children('.caret').toggleClass("fa-caret-down");
            return (false);
        });
                       

        $(".leftmenu .childmenu li").hover(function () {
            $(this).find('.GrandChildmenu:first').css({ visibility: "visible", display: "none" }).stop().fadeIn(400);
        }, function () {
                $(this).find('.GrandChildmenu:first').stop().hide(200);
        });

        $(".videolink").click(function () {
            var url = $(this).attr("val");
            $(".modal-video").html(url);
            $("#myModal").modal();
        })

        $('#myModal').on('hidden.bs.modal', function () {
            $(".modal-video").html("");
        })

        cloneLeftToRight();
        $(window).resize(function () {
            cloneLeftToRight();
        });

        $.ajax({
            type: "GET",
            url: "/SiteVisit/index",
            data: JSON.stringify({}),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data);
                $("#SiteVisit_Yesterday").html(numberWithCommas(data.yesterday));
                $("#SiteVisit_DateOfWeek").html(numberWithCommas(data.dateOfWeek));
                $("#SiteVisit_DateNow").html(numberWithCommas(data.dateNow));
                $("#SiteVisit_Total").html(numberWithCommas(data.total));
            },
            error: function () {

            }
        });

        $.ajax({
            type: "GET",
            url: "/Home/SiteVisit",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
            },
            error: function () {

            }
        });


        
    

    });


    $("#SelectIdQuanHuyen").on('change', function () {
        //alert(this.value);
        $("#SelectIdPhuongXa option").each(function () {
            $(this).remove();
        });
        return $.ajax({
            type: "POST",
            url: "/Big/GetCommunesByDistrict?IdQuanHuyen=" + this.value,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (res) {
                console.log(res);
                for (var i = 0; i < res.length; i++){
                    console.log(res[i].text)
                    $("#SelectIdPhuongXa").append($("<option></option>").val(res[i].value).html(res[i].text));
                }
            }

        });

    }) 

    function cloneLeftToRight() {
        var w = $(window).width();
        if (w <= 991) {

            $(".xsCloneTo").html($(".xsClone").html());
        }
        else {
            $(".xsCloneTo").empty();
        }
     
    }

    //*************************************
    //   BOTTOM SCROLL TOP BUTTON
    //*************************************

    // declare variable
    //var scrollTop = $(".scrollTop");

    //$(window).scroll(function () {
    //    // declare variable
    //    var topPos = $(this).scrollTop();

    //    // if user scrolls down - show scroll to top button
    //    if (topPos > 100) {
    //        $(scrollTop).css("opacity", "1");

    //    } else {
    //        $(scrollTop).css("opacity", "0");
    //    }

    //}); // scroll END

    ////Click event to scroll to top
    //$(scrollTop).click(function () {
    //    $('html, body').animate({
    //        scrollTop: 0
    //    }, 800);
    //    return false;

    //}); // click() scroll top EMD
   


    $('#image-gallery').lightSlider({
        gallery: true,
        item: 1,
        thumbItem: 9,
        slideMargin: 0,
        speed: 800,
        pause: 6000,
        auto: true,
        pager: false,
        controls: false,
        mode:'fade',
        loop: true,
        onSliderLoad: function () {
            $('#image-gallery').removeClass('cS-hidden');
        }
    });


    $('#Features-Slide').lightSlider({
        gallery: true,
        item: 1,
        thumbItem: 9,
        slideMargin: 0,
        speed: 800,
        pause: 4000,
        auto: true,
        pager: false,
        controls: false,
        mode: 'fade',
        loop: true,
        onSliderLoad: function () {
            $('#Features-Slide').removeClass('cS-hidden');
        }
    });




    $('#Features-Slide3').lightSlider({
        gallery: true,
        item: 1,
        slideMargin: 0,
        speed: 1500,
        pause: 4000,
        auto: true,
        pager: false,
        controls: true,
        loop: true

    });


    $('#Features-Slide2').lightSlider({
        gallery: true,
        item: 3,
        slideMargin: 0,
        speed: 800,
        pause: 4000,
        auto: true,
        pager: false,
        controls: true,
        loop: true,
        responsive: [
            {
                breakpoint: 1170,
                settings: {
                    item: 3,
                    slideMove: 1,
                    slideMargin: 6,
                }
            },
            {
                breakpoint: 980,
                settings: {
                    item: 2,
                    slideMove: 1
                }
            },
            {
                breakpoint: 460,
                settings: {
                    item: 1,
                    slideMove: 1
                }
            }
        ]
    });
});



function SubmitSearch() {
    $('form#search-all').submit();
}

function numberWithCommas(number) {
    var parts = number.toString().split(".");
    parts[0] = parts[0].replace(/\B(?=(\d{3})+(?!\d))/g, ",");
    return parts.join(".");
}