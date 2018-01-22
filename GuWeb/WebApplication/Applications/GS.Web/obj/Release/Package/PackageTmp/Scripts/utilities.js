//获取url参数
function getQueryString(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
    var r = window.location.search.substr(1).match(reg);
    if (r != null) return unescape(r[2]); return null;
}

//获取需要跳转的url
function getRedirectURL() {
    var redirectURL = getQueryString("redirectURL");
    redirectURL = redirectURL == null ? "/user/index" : redirectURL;
    return redirectURL;
}

//获取分页代码
function getPageCode(pageIndex, pageCount, host) {
    if (pageCount <= 1) return null;
    var width = $(document).width();
    var isfirst = pageIndex == 1;
    var islast = pageIndex == pageCount;
    var previousurl = isfirst ? "javascript:;" : host + "?pn=" + (pageIndex - 1);
    var nexturl = islast ? "javascript:;" : host + "?pn=" + (pageIndex + 1);
    var firsturl = host + "?pn=1";
    var lasturl = host + "?pn=" + pageCount;
    var pageCode = "";
    pageCode += '<nav>';
    if (width > 700) {//大屏/桌面分页
        pageCode += '<ul class="pagination">';
        //首页/上一页
        if (pageIndex != 1) {
            pageCode += '<li><a href="' + firsturl + '" aria-label="Previous"><span aria-hidden="true">首页</span></a></li>';
            pageCode += '<li><a href="' + previousurl + '" aria-label="Previous"><span aria-hidden="true">上一页</span></a></li>';
        }
        var beginnum = pageIndex <= 5 ? 1 : pageIndex + 5 > pageCount ? pageCount - 9 : pageIndex - 4;
        var endnum = pageIndex <= 5 ? 10 : pageIndex + 5 > pageCount ? pageCount : pageIndex + 5;
        for (var i = beginnum; i <= endnum ; i++) {
            if (i <= 0 || i > pageCount) continue;
            if (i == pageIndex) {
                pageCode += '<li class="active"><a href="javascript:;">' + i + ' <span class="sr-only">(current)</span></a></li>';
                continue;
            }
            var url = host + "?pn=" + i;
            pageCode += '<li><a href="' + url + '">' + i + '</a></li>';
        }
        //下一页/尾页
        if (pageIndex != pageCount) {
            pageCode += '<li><a href="' + nexturl + '" aria-label="Next"><span aria-hidden="true">下一页</span></a></li>';
            pageCode += '<li><a href="' + lasturl + '" aria-label="Next"><span aria-hidden="true">尾页</span></a></li>';
        }
    } else {//手机分页
        pageCode += '<ul class="pager">';
        pageCode += '<li class="previous' + (isfirst ? " disabled" : "") + '"><a href="' + previousurl + '"><span aria-hidden="true">&larr;</span> 上一页</a></li>';
        pageCode += '<li class="next' + (islast ? " disabled" : "") + '"><a href="' + nexturl + '">下一页 <span aria-hidden="true">&rarr;</span></a></li>';
    }
    pageCode += '</ul></nav>';
    return pageCode;
}

//滚动到底部
function toBottom() {
    var h = $(document).height() - $(window).height() + 100;
    $(document).scrollTop(h);
}