
$(function () {
    var isi = $("#isindex").val();
    if (isi != 1) {
        //设置搜索框宽度
        var width = $(document).width();
        if (width > 700)
            $('.kw').width(320);
        else
            $('.kw').width(width - 160);
    }

    //添加输入框智能提示
    $('.kw').autocomplete({
        source: function (request, response) {
            if (request == "") return null;
            var url = '/stock/search?kw=' + request.term;
            $.ajax({
                'url': url,
                dataType: 'json',
                success: function (dataObj) {
                    response(eval(dataObj)); //将数据交给autocomplete去展示
                }
            });
        },
        select: function (event, ui) {
            // 这里的this指向当前输入框的DOM元素
            // event参数是事件对象
            // ui对象只有一个item属性，对应数据源中被选中的对象
            $('.kw').val(ui.item.value);
            // 必须阻止默认行为，因为autocomplete默认会把ui.item.value设为输入框的value值
            event.preventDefault();
            toguba();
        }
    });
    //点击搜索按钮
    $(".search").on("click", function () {
        search();
    });

    function search() {
        var hasVal = false;
        $(".kw").each(function () {
            if ($(this).val() != "") { hasVal = true; };
        });
        if (!hasVal) { window.location.href = "http://www.nichaogu.com"; }
        else toguba();
    }

    function toguba() {
        var kw = $('.kw').eq(0).val() == "" ? $('.kw').eq(1).val() : $('.kw').eq(0).val();
        window.location.href = "/guba/" + kw;
    }
    $(".kw").each(function () {
        $(this).bind('keypress', function (event) {
            if (event.keyCode == "13") {
                event.preventDefault();
                search();
            }
        });
    });
});