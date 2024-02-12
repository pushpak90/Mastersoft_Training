$(document).ready(function () {
    var thead = "";
    thead = thead + '<tr> <th>Name</th><th>Email</th><th>College</th><th>Branch</th><th>Degree</th><th>Branch DDL</th></tr>'
    $('#tbhead').append(thead);

    $.ajax({
        type: "POST",
        url: "/default.aspx/bindtable",
        data: {},
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            $('#tbody').empty;
            console.log(data);
            var str = "";
            for (var i = 0; i < data['d'].length; i++) {
                str = str + '<tr>'
                str = str + '<td>' + data['d'][i]['Name'] + '</td>'
                str = str + '<td>' + data['d'][i]['Email'] + '</td>'
                str = str + '<td>' + data['d'][i]['College'] + '</td>'
                str = str + '<td>' + data['d'][i]['Branch'] + '</td>'
                str = str + '<td>' + data['d'][i]['Degree'] + '</td>'
                str = str + '<td>' + data['d'][i]['Branch_d'] + '</td>'
                str = str + '</tr>';
            }
            $('#tbody').append(str);
        },
        error: function (xhr, status, error) {
        }
    }) 
})

$('#btnSubmit').click(function () {
    var obj = {};
    obj.name = $('#txtName').val();
    obj.email = document.getElementById("txtEmail").value;
    obj.college = $('#txtCollege').val();
    obj.branch = $('#txtBranch').val();
    obj.ddl_deg = $('#ddlDeg').val();
    obj.ddl_branch = $('#ddlbranch').val();

    console.log(obj);
   
    $.ajax({
        url: "/default.aspx/SaveModule",
        type: "POST",
        dataType: 'json',
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(obj),
        success: function (data) {
            console.log('Information Saved Seccessfully');
            alert('Information Saved Seccessfully');
        },
        error: function (errResponse) {
            console.log(errResponse);
            alert(errResponse)
        }

    });
    clear_control();
})


function clear_control() {
    $('#txtName').val("");
    $('#txtEmail').val("");
    $('#txtCollege').val("");
    $('#txtBranch').val("");
}

$('#ddlDeg').change(function () {
    var obj = {};
    obj.deg = $('#ddlDeg').val();
    console.log(obj);

    $.ajax({
        type: "POST",
        url: "/default.aspx/bind_branch",
        data: JSON.stringify(obj),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (bind_ddl_branch) {
            var count = 0;
            if (bind_ddl_branch.d == '') {
                $("#ddlbranch").empty();
                $("#ddlbranch").append($('<option></option>').val("0").html("Please Select"));
            }

            $("#ddlbranch").empty();

            $.each(bind_ddl_branch.d, function (index, GetValue) {
                if (count == 0) {
                    $("#ddlbranch").append($('<option></option>').val("0").html("Please Select"));
                }
                $("#ddlbranch").append($('<option></option>').val(GetValue.ddl_branch_no).html(GetValue.ddl_branch));
                console.log(index.ddl_branch_no);
                console.log(GetValue.ddl_branch);
                count++;
            });
        },
        error: function (errResponse) {
            console.log("data not found");
            console.log(errResponse);
        }

    });
})