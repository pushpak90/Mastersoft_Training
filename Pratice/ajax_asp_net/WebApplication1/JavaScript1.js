$('#btnSave').click(function () {
    console.log("Working");
    console.log($('#fname').val());
    var obj = {};
    obj.name = $('#fname').val();

    $.ajax({
        url: "/todolist.aspx/SaveTodo",
        type: "POST",
        dataType: 'json',
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(obj),
        success: function (data) {
            console.log('Information Saved Seccessfully');
            alert('Information Saved Seccessfully');
            alert(data);
        },
        error: function (errResponse) {
            console.log(errResponse);
            alert(errResponse)
        }

    });
})