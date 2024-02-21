$(document).ready(function () {
    $('#btnsavedata').click(function () {
        
        var txt_name_input = $('#txtName').val();
        var txt_email_input = $('#txtEmail').val();

        console.log(txt_name_input);
        console.log(txt_email_input);

        $.ajax({
            type: 'POST',
            url: '/mywebservice.asmx/ProcessData',
            data: JSON.stringify({ name: txt_email_input, email: txt_name_input }),
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (response) {
                alert(response.d);
            },
            error: function (error) {
                console.error('Error:', error);
            }
        });
    })
})