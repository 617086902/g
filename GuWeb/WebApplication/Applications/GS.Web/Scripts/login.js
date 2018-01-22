
$(function () {
    //点击刷新验证码
    $("#changeImg").click(function () {
        var newSrc = "/common/GetCodeImg" + "?t=" + (new Date()).getTime();
        this.src = newSrc;
        return false;
    });

    //点击登陆
    $("#ensureLogin").click(function () {
        var checkFromRes = checkFrom();
        if (!checkFromRes) return;
        $("#ensureLogin").html("正在登录");
        $.post("/user/userlogin", {
            logincode: $("#logincode").val(),
            passcode: $("#passCode").val(),
            rememberme: true,
            imgCode: $("#validCode").val()
        }, function (data) {
            if (data.code != 0) {
                $("#ensureLogin").html("登陆");
                alert(data.msg);
                return;
            } else {
                window.location.href = getRedirectURL();
            }
        });
    });
    //绑定回车事件
    $("#validCode").bind('keypress', function (event) {
        if (event.keyCode == "13") {
            event.preventDefault();
            $("#ensureLogin").click();
        }
    });


    //检查表单
    function checkFrom() {
        var errcount = 0;
        var mobileReg = /^(1[3578])\d{9}$/i;
        var emailReg = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;//邮箱的验证
        var logincode = $("#logincode").val(), passcode = $("#passCode").val(), validCode = $("#validCode").val();
        if (logincode == "" || (!mobileReg.test(logincode) && !emailReg.test(logincode))) {
            $("#logincode").parent().addClass("has-error");
            errcount++;
        }
        if (passcode == "" || passcode.length < 6 || passcode.length > 20) {
            $("#passCode").parent().addClass("has-error");
            errcount++;
        }
        if (validCode == "" || validCode.length != 4) {
            $("#validCode").parent().addClass("has-error");
            errcount++;
        }
        return errcount <= 0;
    }

    //去掉错误样式
    $(".form-control").focus(function () {
        $(this).parent().removeClass("has-error");
    });
});