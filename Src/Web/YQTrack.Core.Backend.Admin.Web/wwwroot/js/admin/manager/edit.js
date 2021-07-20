﻿layui.use(['layer', 'jquery', 'form'], function () {
    var form = layui.form,
        layer = parent.layer === undefined ? layui.layer : top.layer,
        $ = layui.jquery;

    // 自定义表单验证
    form.verify({
        password: function (value, item) {
            if (value.length > 0) {
                if (!/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,16}$/.test(value)) {
                    return '密码必须8到16位,最少8个字符至少1个大写字母，1个小写字母，1个数字和1个特殊字符';
                }
            }
        },
        confirmPassword: function (value, item) {
            var password = $('input[name="password"]').val();
            if (value !== password) {
                return '请保持两次密码填写一致';
            }
        }
    });

    form.on('switch(locked)', function (data) {
        var value = data.elem.value;
        if (value === 'true') {
            data.elem.value = 'false';
            $(data.elem).removeAttr('checked');
        } else {
            data.elem.value = 'true';
        }
    });

    form.on('submit(form)', function (data) {
        data.field.isLock = $('input[name=isLock]').val();
        $.post('/Admin/Manager/Edit', data.field, function (res) {
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