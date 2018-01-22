$(function () {
    //发表帖子
    var um = UM.getEditor('posteditor');
    $("#postsubmit").on("click", function () {
        var cont = um.getContent();
        if ($("#stockCode").val() == "") {
            alert("error"); return;
        }
        if ($("#posttitle").val() == "") {
            alert("请输入标题"); return;
        }
        if ($("#posttitle").length > 35) {
            alert("标题过长"); return;
        }
        if (cont == "") {
            alert("请输入内容"); return;
        }
        $.post("/post/add", {
            kw: $("#stockCode").val(),
            title: $("#posttitle").val(),
            content: escape(cont)
        }, function (data) {
            if (data.code == 0) {
                window.location.reload();
            } else if (data.code == 1) {
                alert(data.msg);
            }
        });
    });

    var stockcode = $("#stockCode").val();

    //加载数据
    //var pageindex = getQueryString("pn");
    //pageindex = pageindex == null || pageindex == "" ? 1 : pageindex;
    //var stockcode = $("#stockCode").val();
    //getPost(stockcode, pageindex);
    ////加载数据方法
    //function getPost(stockCode, pindex) {
    //    $.get("/post/get", { kw: stockCode, pageIndex: pindex }, function (data) {
    //        if (data && data.code == 0) {
    //            if (data.data.DataCount <= 0) {
    //                $("#postlist").html('<p style="line-height:50px;margin-left:10px;">暂无数据，赶紧抢做第一个发帖人吧。</p>');
    //                return;
    //            }
    //            var template = $.templates("#postdata").render(data.data);
    //            $("#postlist").append(template);
    //            var host = "/guba/" + stockCode;
    //            //加载分页
    //            var pagehtml = getPageCode(data.data.PageIndex, data.data.PageCount, host);
    //            $("#pager").html(pagehtml);
    //        }
    //    });
    //}
});