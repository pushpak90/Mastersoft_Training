$(document).ready(function () {
    $('#savedata').click(function () {
        
        var txt_name_input = $('#txtName').val();
        var txt_email_input = $('#txtEmail').val();
        //console.log(txt_name_input + txt_email_input);

        $.ajax({
            type: 'POST',
            url: 'mywebservice.asmx.cs/SaveUserDetails',
            data: JSON.stringify({ name: txt_name_input, email: txt_email_input }),
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (response) {
                alert(response.d);
            },
            error: function (error) {
                console.error('Web Service Error:', error);
            }
        });
    })
})