$(document).ready(function () {
    console.log("JS file is ready");
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

}