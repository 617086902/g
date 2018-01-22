
$(function () {
    var postid = $("#postid").val();
    var um = UM.getEditor('commenteditor');
    $("#commentsubmit").on("click", function () {
        var cont = um.getContent();
        if (cont == "") {
            alert("请输入评论内容"); return;
        }
        var pcid = $("#pcid").val() == "" ? 0 : parseInt($("#pcid").val());
        var tuser = $("#toUserName").val();
        reply(postid, escape(cont), pcid, tuser);
    });

    //发表回复
    function reply(postid, content, pcid, tname) {
        $.post("/post/addcomment", {
            postId: postid,
            content: content,
            parentCommentId: pcid,
            toUserName: tname
        }, function (data) {
            if (data.code == 0) {
                //todo:展示发表评论成功动画
                window.location.reload();
            } else if (data.code == 1) {
                window.location.href = "/user/login?redirectURL=" + window.location.href;
            }
        });
    }

    $(".reply-post").each(function () {
        $(this).click(function () {
            um.setContent(""); um.focus(); toBottom();
        })
    });

    //加载数据
    var pageindex = getQueryString("pn");
    pageindex = pageindex == null || pageindex == "" ? 1 : pageindex;
    getComment(postid, pageindex);

    //加载数据方法
    function getComment(postId, pindex) {
        $.get("/post/getcomment", { pid: postId, pageIndex: pindex }, function (data) {
            if (data && data.code == 0) {
                console.log(data)
                var template = $.templates("#commentdata").render(data.data);
                $("#commentlist").append(template);
                var host = "/p/" + postId;
                //加载分页
                var pagehtml = getPageCode(data.data.PageIndex, data.data.PageCount, host);
                console.log(pagehtml);
                $("#pager").html(pagehtml);

                //设置内容高度
                var width = $(document).width();
                if (width > 750) {
                    $('.comment-contain').css("min-height", 115);
                    $('.comment-bg').css("background", 'url("/Content/img/bg_l.jpg") repeat-y');
                }

                //绑定回复事件
                $(".reply").each(function (index) {
                    var _this = $(this);
                    _this.click(function () {
                        um.setContent("");
                        $("#pcid").val(_this.data("cid"));
                        um.focus();
                        toBottom();
                    });
                });
                $(".reply-c").each(function (index) {
                    var _this = $(this);
                    _this.click(function () {
                        um.setContent("");
                        um.setContent('<p>回复 ' + _this.data("cname") + ":</p>");
                        $("#pcid").val(_this.data("cid"));
                        $("#toUserName").val(_this.data("cname"));
                        um.focus();
                        toBottom();
                    });
                });
            }
        });
    }


    $.get("/common/islike", { targetId: $("#like").data("postid"), targetType: 1 }, function (data) {
        if (data && data.code == 0) {
            $("#like").html(data.data ? "[取消收藏]" : "[收藏]");
            $("#like").data("islike", data.data ? false : true);
        }
    });
    $("#like").click(function () {
        var islike = $("#like").data("islike");
        $.post("/common/likeorunlike", { targetId: $(this).data("postid"), targetType: 1, isLike: islike }, function (data) {
            if (data && data.code == 0) {
                $("#like").html(islike ? "[取消收藏]" : "[收藏]");
            }
        });
    });
});