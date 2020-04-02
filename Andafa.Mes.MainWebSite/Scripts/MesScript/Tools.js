/// <reference path="../Scripts/jquery.base64.js" />

//显示错误信息
function ErrorShow(msg) {
    var obj = $('<div class="alert alert-danger" role="alert"><span class="glyphicon  glyphicon glyphicon-remove" aria-hidden="true"></span><span class="sr-only">Error:</span> ' + msg + '</div>');
    $('#errorStatus').empty();
    $('#errorStatus').append(obj);
    $('#errorStatus').show();
}

//隐藏错误信息
function ErrorHide() {
    $('#errorStatus').empty();
    $('#errorStatus').hide();
}

//显示错误信息
function TipShow(msg) {
    var obj = $('<div class="alert alert-danger" role="alert"><span class="glyphicon  glyphicon glyphicon-remove" aria-hidden="true"></span><span class="sr-only">Error:</span> ' + msg + '</div>');
    $('#infoTip').empty();
    $('#infoTip').append(obj);
    $('#infoTip').show();
}

//隐藏错误信息
function TipHide() {
    $('#infoTip').empty();
    $('#infoTip').hide();
}

//64位格式转换
function strBase64(orignalStr) {
    $.base64.utf8encode = true;
    return $.base64.btoa(orignalStr);
};


//64位格式转换
function strBase64Reverse(orignalStr) {
    $.base64.utf8decode = true;
    return $.base64.atob(orignalStr);
};