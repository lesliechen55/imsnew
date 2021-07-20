﻿layui.use(['layer', 'jquery', 'form'], function () {
    var form = layui.form,
        layer = parent.layer === undefined ? layui.layer : top.layer,
        $ = layui.jquery;

    var split = window.data.split('|');

    form.val('form', {
        'status': split[0],
        'detail': split[1]
    });

    form.on('submit(form)', function (data) {

        if (data.field.status === '1') {
            var detail = $('#detail').val();
            if ($.trim(detail).length <= 0) {
                layer.msg('当处理为有效举报,处理说明不能为空');
                return false;
            }
        }

        $.post('/Freight/Report/Process', data.field, function (res) {
            if (!res.success) {
                layer.alert('操作失败:' + res.msg, { title: '错误', icon: 5 });
                return false;
            }
            layer.msg('操作成功', { icon: 6 });

            // 刷新父级页面
            top.refreshParent();
            $('#close').click();
            return false;
        });
        return false; //阻止表单跳转。如果需要表单跳转，去掉这段即可。
    });

    $('#close').click(function () {
        //当你在iframe页面关闭自身时
        var index = parent.layer.getFrameIndex(window.name); //先得到当前iframe层的索引
        parent.layer.close(index); //再执行关闭
    });

});