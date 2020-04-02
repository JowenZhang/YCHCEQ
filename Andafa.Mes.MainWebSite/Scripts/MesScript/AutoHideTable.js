//genneral table
var TableInit = function () {
    var oTableInit = new Object();
    //初始化Table
    oTableInit.Init = function () {
        oTableInit.createColumns();
        $('.table-auto-hide').bootstrapTable({
            url: oTableInit.url,//'/Operator/GetWorkerSelectedWkaData',         //请求后台的URL（*）
            method: oTableInit.method,                      //请求方式（*）
            //toolbar: '#toolbar',                //工具按钮用哪个容器
            striped: true,                      //是否显示行间隔色
            cache: false,                       //是否使用缓存，默认为true，所以一般情况下需要设置一下这个属性（*）
            pagination: false,                   //是否显示分页（*）
            sortable: false,                     //是否启用排序
            sortOrder: 'asc',                   //排序方式
            queryParams: oTableInit.queryParams, //传递参数（*）
            //sidePagination: 'server',           //分页方式：client客户端分页，server服务端分页（*）
            //pageNumber: 1,                       //初始化加载第一页，默认第一页
            //pageSize: 100,                       //每页的记录行数（*）
            //pageList: [100, 200, 400, 500],        //可供选择的每页的行数（*）
            search: false,                       //是否显示表格搜索，此搜索是客户端搜索，不会进服务端，所以，个人感觉意义不大
            strictSearch: false,
            //showColumns: true,                  //是否显示所有的列
            //showRefresh: true,                  //是否显示刷新按钮
            minimumCountColumns: 2,             //最少允许的列数
            clickToSelect: true,                //是否启用点击选中行
            uniqueId: oTableInit.uniqueId,                     //每一行的唯一标识，一般为主键列
            showToggle: false,                    //是否显示详细视图和列表视图的切换按钮
            cardView: false,                    //是否显示详细视图
            detailView: false,                   //是否显示父子表
            singleSelect: oTableInit.singleSelect,                  //是否单选一行
            locale: 'zh-CN',
            columns: oTableInit.columns,
            onPostHeader: oTableInit.myHeaderStyle,
            onPostBody: oTableInit.bindDetail
        });
    };

    oTableInit.url = '';

    oTableInit.autoHideColumns = [];

    oTableInit.singleSelect = false;

    oTableInit.uniqueId = 'id';

    oTableInit.method = 'get';

    oTableInit.bindDetail = function (data) {
        $('.btn-my-detail').click(function () {
            var index = $(this).attr('data-index');
            var rows = $('.table-auto-hide').bootstrapTable('getData');
            if (rows.length > index) {
                //ShowDetailFrm($('.table-auto-hide'), '详情对话框', rows[index], oTableInit.columnSettings);//
                var contentStr = '<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true"><div class="modal-dialog"><div class="modal-content"><div class="modal-header"><h6 class="modal-title" id="myModalLabel">详情</h6></div><div class="modal-body"><div class="container-fluid"><div class="row-fluid"><table class="table table-striped table-sm table-condensed">';
                var tmpStr = '';
                for (var i = 0; i < oTableInit.columnSettings.length; i++) {
                    var tag = oTableInit.columnSettings[i].title;
                    var proVal = rows[index][oTableInit.columnSettings[i].field];
                    if (proVal == null) {
                        proVal = '-';
                    } else if (proVal == true) {
                        proVal = '是';
                    } else if (proVal == false) {
                        proVal = '否';
                    }
                    else if (proVal == '') {
                        proval = '-';
                    }
                    tmpStr = tmpStr + '<tr><td>' + tag + '</td><td>' + proVal + '</td></tr>';
                }
                contentStr = contentStr + tmpStr;
                contentStr = contentStr + '</table></div></div></div><div class="modal-footer"><button type="button" class="btn btn-default" data-dismiss="modal">关闭</button></div></div></div></div>';
                var content = $(contentStr);
                $('.table-auto-hide').after(content);
                $('.modal').modal('show');
                $('.modal').on('hide.bs.modal', function () {
                    content.remove();
                });
            }
        });
    };


    oTableInit.columnSettings = [];

    oTableInit.columns = [];

    oTableInit.createColumns = function () {
        if (oTableInit.columnSettings == null || oTableInit.columnSettings.length <= 0) {
            oTableInit.columns = [];
        } else {
            var columns = [];
            for (var i = 0; i < oTableInit.columnSettings.length; i++) {

                if (oTableInit.columnSettings[i].checkbox) {
                    oTableInit.columns.push({ field: oTableInit.columnSettings[i].field, title: oTableInit.columnSettings[i].title, checkbox: oTableInit.columnSettings[i].checkbox });
                }
                else {
                    if (oTableInit.columnSettings[i].columnStyle) {
                        oTableInit.autoHideColumns.push(oTableInit.columnSettings[i].title);
                        oTableInit.columns.push({ field: oTableInit.columnSettings[i].field, title: oTableInit.columnSettings[i].title, cellStyle: oTableInit.myCellStyle });
                    } else {
                        oTableInit.columns.push({ field: oTableInit.columnSettings[i].field, title: oTableInit.columnSettings[i].title });
                    }
                }
            }
            oTableInit.columns.push({ field: "operater", title: "操作", formatter: oTableInit.attachBtnFormatter })
        }
    };

    oTableInit.attachBtnFormatter = function (value, row, index) {
        str = '<button class=\"btn btn-primary btn-sm btn-my-detail\" data-index="' + index + '">详细</button>';
        return str;
    };
    //格式化列
    oTableInit.myCellStyle = function (value, row, index, field) {
        return { classes: 'hidden-xs hidden-sm visible-md visible-lg' };
    };

    oTableInit.myHeaderStyle = function () {
        $('.table-auto-hide thead tr').each(function (i) {  // 遍历 tr
            $(this).children('th').each(function (j) {  // 遍历 tr 的各个 td
                var val = $(this).text();
                if (oTableInit.autoHideColumns != null && oTableInit.autoHideColumns.indexOf(val) > -1) {
                    $(this).removeClass("hidden-xs hidden-sm visible-md visible-lg");
                    $(this).addClass("hidden-xs hidden-sm visible-md visible-lg");
                }
            });
        });
    }
    //得到查询的参数
    oTableInit.queryParams = function (params) {
        var temp = {//这里的键的名字和控制器的变量名必须一致，这边改动，控制器也需要改成一样的
            pageSize: params.limit,   //页面大小
            pageIndex: (params.offset / params.limit) + 1 //页码
        };
        return temp;
    };
    return oTableInit;
}

var GroupSingleTableInit = function () {
    var oTableInit = new Object();
    //初始化Table
    oTableInit.Init = function () {
        oTableInit.createColumns();
        $('.table-auto-hide').bootstrapTable({
            url: oTableInit.url,//'/Operator/GetWorkerSelectedWkaData',         //请求后台的URL（*）
            method: oTableInit.method,                      //请求方式（*）
            //toolbar: '#toolbar',                //工具按钮用哪个容器
            striped: true,                      //是否显示行间隔色
            cache: false,                       //是否使用缓存，默认为true，所以一般情况下需要设置一下这个属性（*）
            pagination: false,                   //是否显示分页（*）
            sortable: false,                     //是否启用排序
            sortOrder: 'asc',                   //排序方式
            queryParams: oTableInit.queryParams, //传递参数（*）
            //sidePagination: 'server',           //分页方式：client客户端分页，server服务端分页（*）
            //pageNumber: 1,                       //初始化加载第一页，默认第一页
            //pageSize: 100,                       //每页的记录行数（*）
            //pageList: [100, 200, 400, 500],        //可供选择的每页的行数（*）
            search: false,                       //是否显示表格搜索，此搜索是客户端搜索，不会进服务端，所以，个人感觉意义不大
            strictSearch: false,
            //showColumns: true,                  //是否显示所有的列
            //showRefresh: true,                  //是否显示刷新按钮
            minimumCountColumns: 2,             //最少允许的列数
            clickToSelect: false,                //是否启用点击选中行
            uniqueId: oTableInit.uniqueId,                     //每一行的唯一标识，一般为主键列
            showToggle: false,                    //是否显示详细视图和列表视图的切换按钮
            cardView: false,                    //是否显示详细视图
            detailView: false,                   //是否显示父子表
            singleSelect: false,                  //是否单选一行
            locale: 'zh-CN',
            columns: oTableInit.columns,
            onPostHeader: oTableInit.myHeaderStyle,
            onPostBody: oTableInit.bindDetail,
            onClickRow:oTableInit.bindClickRow
        });
    };

    oTableInit.url = '';

    oTableInit.autoHideColumns = [];

    oTableInit.uniqueId = 'id';

    oTableInit.method = 'get';

    oTableInit.bindClickRow = function (row, e, field) {
        var rows = $('.table-auto-hide').bootstrapTable('getData');
        var selectedRows = $('.table-auto-hide').bootstrapTable('getSelections');
        if (rows.length < 1) {
            return;
        } else {
            for (var i = 0; i < rows.length; i++) {
                if (rows[i].wka_no == row.wka_no && rows[i].mo_no != row.mo_no) {
                    $('.table-auto-hide').bootstrapTable('uncheck', i);
                }
                if (rows[i].wka_no == row.wka_no && rows[i].mo_no == row.mo_no) {
                    if (selectedRows.indexOf(rows[i])>-1) {
                        $('.table-auto-hide').bootstrapTable('uncheck', i);
                    }
                    else {
                        $('.table-auto-hide').bootstrapTable('check', i);
                    }
                }
            }
            return;
        }
    }

    oTableInit.bindDetail = function (data) {
        $('.btn-my-detail').click(function () {
            var index = $(this).attr('data-index');
            var rows = $('.table-auto-hide').bootstrapTable('getData');
            if (rows.length > index) {
                //ShowDetailFrm($('.table-auto-hide'), '详情对话框', rows[index], oTableInit.columnSettings);//
                var contentStr = '<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true"><div class="modal-dialog"><div class="modal-content"><div class="modal-header"><h6 class="modal-title" id="myModalLabel">详情</h6></div><div class="modal-body"><div class="container-fluid"><div class="row-fluid"><table class="table table-striped table-sm table-condensed">';
                var tmpStr = '';
                for (var i = 0; i < oTableInit.columnSettings.length; i++) {
                    var tag = oTableInit.columnSettings[i].title;
                    var proVal = rows[index][oTableInit.columnSettings[i].field];
                    if (proVal == null) {
                        proVal = '-';
                    } else if (proVal==0) {
                        proVal = '0';
                    } else if (proVal == true) {
                        proVal = '是';
                    } else if (proVal == false) {
                        proVal = '否';
                    } else if (proVal == '') {
                        proval = '-';
                    }
                    tmpStr = tmpStr + '<tr><td>' + tag + '</td><td>' + proVal + '</td></tr>';
                }
                contentStr = contentStr + tmpStr;
                contentStr = contentStr + '</table></div></div></div><div class="modal-footer"><button type="button" class="btn btn-default" data-dismiss="modal">关闭</button></div></div></div></div>';
                var content = $(contentStr);
                $('.table-auto-hide').after(content);
                $('.modal').modal('show');
                $('.modal').on('hide.bs.modal', function () {
                    content.remove();
                });
            }
        });
    };


    oTableInit.columnSettings = [];

    oTableInit.columns = [];

    oTableInit.createColumns = function () {
        if (oTableInit.columnSettings == null || oTableInit.columnSettings.length <= 0) {
            oTableInit.columns = [];
        } else {
            var columns = [];
            for (var i = 0; i < oTableInit.columnSettings.length; i++) {

                if (oTableInit.columnSettings[i].checkbox) {
                    oTableInit.columns.push({ field: oTableInit.columnSettings[i].field, title: oTableInit.columnSettings[i].title, checkbox: oTableInit.columnSettings[i].checkbox });
                }
                else {
                    if (oTableInit.columnSettings[i].columnStyle) {
                        oTableInit.autoHideColumns.push(oTableInit.columnSettings[i].title);
                        oTableInit.columns.push({ field: oTableInit.columnSettings[i].field, title: oTableInit.columnSettings[i].title, cellStyle: oTableInit.myCellStyle });
                    } else {
                        oTableInit.columns.push({ field: oTableInit.columnSettings[i].field, title: oTableInit.columnSettings[i].title });
                    }
                }
            }
            oTableInit.columns.push({ field: "operater", title: "操作", formatter: oTableInit.attachBtnFormatter })
        }
    };

    oTableInit.attachBtnFormatter = function (value, row, index) {
        str = '<button class=\"btn btn-primary btn-sm btn-my-detail\" data-index="' + index + '">详细</button>';
        return str;
    };
    //格式化列
    oTableInit.myCellStyle = function (value, row, index, field) {
        return { classes: 'hidden-xs hidden-sm visible-md visible-lg' };
    };

    oTableInit.myHeaderStyle = function () {
        $('.table-auto-hide thead tr').each(function (i) {  // 遍历 tr
            $(this).children('th').each(function (j) {  // 遍历 tr 的各个 td
                var val = $(this).text();
                if (oTableInit.autoHideColumns != null && oTableInit.autoHideColumns.indexOf(val) > -1) {
                    $(this).removeClass("hidden-xs hidden-sm visible-md visible-lg");
                    $(this).addClass("hidden-xs hidden-sm visible-md visible-lg");
                }
            });
        });
    }
    //得到查询的参数
    oTableInit.queryParams = function (params) {
        var temp = {//这里的键的名字和控制器的变量名必须一致，这边改动，控制器也需要改成一样的
            pageSize: params.limit,   //页面大小
            pageIndex: (params.offset / params.limit) + 1 //页码
        };
        return temp;
    };
    return oTableInit;
}