$(function () {
    $(".regist").attr("href", "/user/regist?redirectURL=" + window.location);
    $(".login").attr("href", "/user/login?redirectURL=" + window.location);

    $("#logout").click(function () {
        $.post("/user/LoginOut", function (data) {
            if (data.code == 0) {
                window.location.href = "/";
            }
        });
    });
    //在手机上不现实下拉菜单，直接跳转
    $(document).on("click", ".dropdown-toggle", function () {
        if ($(window).width() <= 767) {
            $(".dropdown-menu").hide();
            if ($(this).attr("href")) window.location = $(this).attr("href");
        }
    });
});