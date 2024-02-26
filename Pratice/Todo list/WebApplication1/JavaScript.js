$(document).ready(function () {
    load();
})

function load() {
    console.log('Fetching data');

    var Obj = {};
    Obj.Id = 1;

    $.ajax({
        url: baseUrl + "default.aspx/printTodo",
        type: "POST",
        dataType: "JSON",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(Obj),
        success: function (data) {
            var res = "";
            var checkbox = '<input type="checkbox" name="checkboxName">';
            var input = '<input type="button" name="button" value="delete">';
            for (var i = 0; i < data['d'].length; i++) {

                res = res + checkbox + data['d'][i]['todo_msg'] + input +'<br/>';
                
            }
            $('#todomsg').empty().append(res);
        },
        error: function () {
            console.log('Not Connected');
        }
    })
}



$('#btnSave').click(function () {
    console.log("Working");
    //console.log($('#fname').val());
    var obj = {};
    obj.name = $('#tname').val();

    $.ajax({
        url: baseUrl + "default.aspx/SaveTodo",
        type: "POST",
        dataType: 'json',
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(obj),
        success: function (data) {
            console.log(data.name);
            load();
            for (var i = 0; i < data.length; i++) {
                console.log(data.name);
            }
        },
        error: function (errResponse) {
            console.log('Error');
        }
    });
});