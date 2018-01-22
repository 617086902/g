$(function () {
    //点击刷新验证码
    $("#changeImg").click(function () {
        var newSrc = "/common/GetCodeImg" + "?t=" + (new Date()).getTime();
        this.src = newSrc;
        return false;
    });

    //点击确认提交
    $("#ensure").click(function () {
        var checkFromRes = checkFrom();
        if (!checkFromRes) return;
        //判断号码是否已注册
        $.get("/user/CheckIsRegisted", { key: $("#userAccount").val() }, function (res) {
            if (res.code != 0) {
                alert(res.msg);
                return;
            }
            $(".container").eq(0).hide();
            $(".container").eq(1).show();
            $("#regUserAccount").html($("#userAccount").val());
            setTimeout(clickSendMsgBtn, 200);
        });
    });

    //绑定回车事件
    $("#validCode").bind('keypress', function (event) {
        if (event.keyCode == "13") {
            event.preventDefault();
            $("#ensure").click();
        }
    });

    //检查表单
    function checkFrom() {
        var errcount = 0;
        var mobileReg = /^(1[3578])\d{9}$/i;//手机验证
        var emailReg = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;//邮箱的验证
        var username = $("#username").val(), userAccount = $("#userAccount").val(),
            passcode = $("#passCode").val(), validCode = $("#validCode").val();
        if (username == "") {
            $("#username").parent().addClass("has-error");
            errcount++;
        }
        if (userAccount == "" || (!mobileReg.test(userAccount) && !emailReg.test(userAccount))) {
            $("#userAccount").parent().addClass("has-error");
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
        if (errcount > 0) return false;
        var res = $.ajax({
            url: "/common/CheckValidCode",
            async: false,
            data: { code: validCode },
        }).responseText;
        res = JSON.parse(res);
        if (res.code != 0) {
            alert(res.msg);
            return false;
        } else {
            return true;
        }
    }

    //去掉错误样式
    $(".form-control").focus(function () {
        $(this).parent().removeClass("has-error");
    });

    //绑定点击发送验证码按钮事件
    $("#sendmsg").on("click", clickSendMsgBtn);

    //点击发送验证码按钮方法
    function clickSendMsgBtn() {
        $("#sendmsg").attr("disabled", "disabled");
        var res = sendMessage();
        res = JSON.parse(res);
        if (res.code != 0) {
            $("#sendmsg").html("重新发送");
            $("#sendmsg").removeAttr("disabled");
            alert(res.msg);
            return;
        }
        var second = 90;
        var timer = setInterval(function () {
            $("#sendmsg").html(second + "秒后重新发送");
            if (second == 0) {
                $("#sendmsg").html("重新发送");
                $("#sendmsg").removeAttr("disabled");
                clearInterval(timer);
            }
            second--;
        }, 1000);

    }

    //发送短信验证码
    function sendMessage() {
        var res = $.ajax({
            url: "/common/SendMessage",
            async: false,
            data: { userAccount: $("#userAccount").val() },
        }).responseText;
        return res;
    }

    //绑定点击提交表单时间
    $("#presub").on("click", checkMsgCodeAndSubmit);

    //验证短信验证码并注册
    function checkMsgCodeAndSubmit() {
        var messageCode = $("#messageCode").val();
        if (messageCode == "" || messageCode.length < 6) {
            $("#messageCode").parent().addClass("has-error");
            return;
        }
        //验证短信验证码
        $.get("/common/CheckMessageCode", { userAccount: $("#userAccount").val(), code: messageCode }, function (res) {
            if (res.code != 0) {
                alert(res.msg);
                return;
            }
            //注册用户
            $.post("/User/RegistUser", { username: $("#username").val(), validUserAccount: $("#userAccount").val(), passcode: $("#passCode").val() }, function (data) {
                if (data.code != 0) {
                    alert(data.msg);
                    return;
                }
                window.location.href = getRedirectURL();
            });
        });
    }
});