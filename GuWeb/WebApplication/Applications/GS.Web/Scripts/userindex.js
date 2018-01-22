
$(function () {
    //设置搜索框宽度
    var width = $(document).width();
    if (width < 700) {
        $('.m-contain').css("padding", 0);
        $('.showdate').css("float", "left");
    }

    $.get("/user/getUserPost", function (data) {
        if (data && data.code == 0) {
            $("#postCount").html(data.data.DataCount);
            if (data.data.DataCount <= 0) {
                $("#mp").html("暂无数据");
                return;
            }
            var template = $.templates("#postdata").render(data.data);
            $("#mp").html("");
            $("#mp").append(template);
        }
    });
    $.get("/user/getUserLikePost", function (data) {
        if (data && data.code == 0) {
            $("#likeCount").html(data.data.DataCount);
            if (data.data.DataCount <= 0) {
                $("#lp").html("暂无数据");
                return;
            }
            var template = $.templates("#likepostdata").render(data.data);
            $("#lp").html("");
            $("#lp").append(template);
        }
    });

    $("#logout-xs").click(function () {
        $.post("/user/LoginOut", function (data) {
            if (data.code == 0) {
                window.location.href = "/";
            }
        });
    });
});