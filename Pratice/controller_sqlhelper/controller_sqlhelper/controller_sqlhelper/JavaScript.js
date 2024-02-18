$(document).ready(function () {

    $('#ddlDegree').change(function () {
        var deg_id = $('#ddlDegree').val();
        console.log(deg_id);

        $.ajax({
            url: "/default.aspx/bind_Branch",
            type: "POST",
            dataType: 'json',
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify({ value: deg_id }),
            success: function (data) {
                console.log('Branch Bind');
            },
            error: function (errResponse) {
                console.log(errResponse);
                alert(errResponse)
            }
        })

    })

    $('#btnSubmit').click(function () {

        var ob = {};
        ob.FirstName = $('#txtFirstName').val();
        ob.LastName = $('#txtLastName').val();
        ob.College = $('#txtCollege').val();
        ob.Mobile = $('#txtMobileNo').val();
        
        if (true)
        {
            $.ajax({
                url: "/default.aspx/SaveModule",
                type: "POST",
                dataType: 'json',
                contentType: "application/json;charset=utf-8",
                data: JSON.stringify(ob),
                success: function (data) {
                    console.log('Information Saved Seccessfully');
                    alert('Information Saved Seccessfully');
                },
                error: function (errResponse) {
                    console.log(errResponse);
                    alert(errResponse)
                }
            });
        }
        
    })
})

function validation() {
    
}