$(document).ready(function () {
    $('#btnAdd').click(function () {
        console.log("btnAdd Click");
        $.ajax({
            type: "POST",
            url: "default.aspx/YourWebMethod",
            data: JSON.stringify({ parameter1: 'value1', parameter2: 'value2' }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                alert(response.d);
            },
            error: function (error) {
                console.log('Error: ' + error.responseText);
            }
        });
    })
})