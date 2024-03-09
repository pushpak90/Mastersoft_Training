$(document).ready(function () {
    console.log("JS file is ready");
    createTable();
})

$('#btnSubmit').click(function () {

    var obj = {};
    obj.firstName = $('#txtFirstName').val();
    obj.lastName = $('#txtLastName').val();

    $.ajax({
        url: "default.aspx/Submit",
        type: "POST",
        dataType: 'json',
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(obj),
        success: function (data) {
            console.log('Information Saved Seccessfully');
            console.log(data);
        },
        error: function (errResponse) {
            console.log(errResponse);
        }
    });
})

function createTable() {
    $.ajax({
        type: "POST",
        url: "default.aspx/bindTable",
        data: {},
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            var str = '';
            str = str + '<table border="1">';
            str = str + '<thead>' + '<tr>' + '<th>' + 'First Name' + '</th>';
            str = str + '<th>' + 'Last Name' + '</th>';
            str = str + '<th>' + 'City' + '</th>';
            str = str + '<th>' + 'Mobile' + '</th>';
            str = str + '</tr>' + '</thead>';
            str = str + '<tbody>';
            for (var i = 0; i < data['d'].length; i++) {
                str = str + '<td>' + data['d'][i]['firstName'] + '</td>'
                str = str + '<td>' + data['d'][i]['lastName'] + '</td>'
                str = str + '<td>' + '<input type="text" placeholder="Enter City" />' + '</td>'
                str = str + '<td>' + '<input type="text" placeholder="Enter Mobile"/>' + '</td>'
            }
            str = str + '</tbody>' + '</table>';

            $('#table').append(str);
            console.log("Table");
            
        },
        error: function (xhr, status, error) {
            console.log(xhr + status + error);
        }
    })
}

