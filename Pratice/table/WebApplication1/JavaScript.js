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
            alert('Information Saved Seccessfully');
            console.log(data);
            $('#table').empty();
            createTable();
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
                str = str + '<tr>'
                str = str + '<td>' + data['d'][i]['firstName'] + '</td>'
                str = str + '<td>' + data['d'][i]['lastName'] + '</td>'
                str = str + '<td>' + '<input type="text" placeholder="Enter City" />' + '</td>'
                str = str + '<td>' + '<input type="text" placeholder="Enter Mobile"/>' + '</td>'
                str = str + '</tr>'
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

$('#btnSubmitTable').click(function () {
    var dataArray = [];

    $('#table tbody tr').each(function () {
        var city = $(this).find('input[placeholder="Enter City"]').val();
        var mobile = $(this).find('input[placeholder="Enter Mobile"]').val();

        // Create an object for each row and push it to the dataArray
        dataArray.push({ city: city, mobile: mobile });

        // Log the data to the console (optional)
        console.log("City: " + city + ", Mobile: " + mobile);
    });

    // Make an AJAX call to send the data in JSON format
    $.ajax({
        type: "POST",
        url: "default.aspx/SaveTableData",
        data: JSON.stringify({ data: dataArray }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            // Handle success if needed
            console.log("Data saved successfully on the server");
        },
        error: function (errResponse) {
            // Handle error if needed
            console.log(errResponse);
        }
    });
})