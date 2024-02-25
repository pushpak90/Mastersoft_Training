﻿$('#btnSave').click(function () {
    console.log("Working");
    //console.log($('#fname').val());
    var obj = {};
    obj.name = $('#fname').val();

    $.ajax({
        url: baseUrl + "default.aspx/SaveTodo",
        type: "POST",
        dataType: 'json',
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(obj),
        success: function (data) {
            console.log(data.name);
            for (var i = 0; i < data.length; i++) {
                console.log(data.name);
            }
        },
        error: function (errResponse) {
            console.log('Error');
        }
    });
});