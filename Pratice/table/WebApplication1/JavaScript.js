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
            str = str + '<th>' + 'Action' + '</th>';
            str = str + '</tr>' + '</thead>';
            str = str + '<tbody>';

            for (var i = 0; i < data['d'].length; i++) {
                if (data['d'][i]['city'] == "" || data['d'][i]['mobile'] == "") {
                    str = str + '<tr>'
                    str = str + '<td class="firstName">' + data['d'][i]['firstName'] + '</td>'
                    str = str + '<td class="lastName">' + data['d'][i]['lastName'] + '</td>'
                    str = str + '<td>' + '<input type="text" placeholder="Enter City" value="' + data['d'][i]['city'] + '"/></td>'
                    str = str + '<td>' + '<input type="text" placeholder="Enter Mobile" value="' + data['d'][i]['mobile'] + '"/>' + '</td>'
                }
                else
                {
                    str = str + '<tr>'
                    str = str + '<td class="firstName">' + data['d'][i]['firstName'] + '</td>'
                    str = str + '<td class="lastName">' + data['d'][i]['lastName'] + '</td>'
                    str = str + '<td>' + '<input type="text" placeholder="Enter City" value="' + data['d'][i]['city'] + ' " readonly/></td>'
                    str = str + '<td>' + '<input type="text" placeholder="Enter Mobile" value="' + data['d'][i]['mobile'] + '"readonly/>' + '</td>'
                }
                str = str + '<td>' +'<input type="button" class="btnDelete" value="Delete">'+'</td>';
                str = str + '</tr>'
            }
            str = str + '</tbody>' + '</table>';

            $('#table').append(str);
            console.log("Table");
        },
        error: function (xhr, status, error) {
            console.log(xhr + status + error);
        },
        complete: function () {
            // After creating the table, attach the event handler for the submit button
            attachSubmitHandler();
            attachDeleteHandler();
        }
    });
}

function attachDeleteHandler() {
    $('#table').on('click', '.btnDelete', function () {
        console.log('Delete button clicked');

        // Find the closest parent <tr> and then find the desired elements within that row
        var row = $(this).closest('tr');
        var name = row.find('.firstName').text();
        var lastName = row.find('.lastName').text();
        var city = row.find('input[placeholder="Enter City"]').val();
        var mobile = row.find('input[placeholder="Enter Mobile"]').val();

        console.log(name + ' ' + lastName + ' ' + city + ' ' + mobile);

        var dataArray = {
            name: name,
            lastName: lastName,
            city: city,
            mobile: mobile
        };

        $.ajax({
            type: "POST",
            url: "default.aspx/deleteRow",
            data: JSON.stringify({ data: dataArray }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                // Handle success if needed
                console.log(data);
            },
            error: function (errResponse) {
                // Handle error if needed
                console.log(errResponse);
            }
        });

    });
}

function attachSubmitHandler() {
    $('#btnSubmitTable').off('click').on('click', function () {
        var dataArray = [];

        $('#table tbody tr').each(function () {
            if ($(this).find('input[placeholder="Enter City"]').val() != "" && $(this).find('input[placeholder="Enter Mobile"]').val())
            {
                var name = $(this).find('.firstName').text();
                var lastname = $(this).find('.lastName').text();
                var city = $(this).find('input[placeholder="Enter City"]').val();
                var mobile = $(this).find('input[placeholder="Enter Mobile"]').val();
            }
           
            dataArray.push({ city: city, mobile: mobile, name: name, lastname: lastname });
            console.log("City: " + city + ", Mobile: " + mobile + ", First Name: " + name + ", Last Name: " + lastname);
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
                console.log(data);
            },
            error: function (errResponse) {
                // Handle error if needed
                console.log(errResponse);
            }
        });
    });
}