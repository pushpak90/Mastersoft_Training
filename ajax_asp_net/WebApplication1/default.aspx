<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <%--<script src="JavaScript.js" type="text/javascript"></script>--%>
    <script src="jquery-3.7.1.min.js"></script>
    <script src="https://code.jquery.com/jquery-1.11.1.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <style>
        table {
            color: white;
        }

        /* Optional: Add styles for better visibility, such as background color */
        table, th, td {
            border: 1px solid black;
            border-collapse: collapse;
            padding: 10px;
        }

        /* Optional: Set background color for header cells */
        th {
            background-color: #333;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddlDeg" runat="server">
            <asp:ListItem Value="0">Please Select</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlbranch" runat="server">
            <asp:ListItem Value="0">Please Select</asp:ListItem>
        </asp:DropDownList>
        <div>
            <div id="container">
                <header>Register new account</header>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <fieldset>
                        <br />
                        <input type="text" name="username" id="txtName" placeholder="Username" />
                        <br />
                        <br />
                        <input type="text" name="email" id="txtEmail" placeholder="E-mail" />
                        <br />
                        <br />
                        <input type="text" name="password" id="txtCollege" placeholder="College" />
                        <br />
                        <br />
                        <input type="text" name="confirm-password" id="txtBranch" placeholder="Branch" />
                        <br />
                        <br />
                        <br />
                        <button type="button" id="btnSubmit">Submit</button>
                    </fieldset>
                </div>
            </div>
        </div>
        <table border="1">
            <!-- Table header row -->
            <thead id="tbhead">

            </thead>
            <!-- Table body rows -->
            <tbody id="tbody">
                
            </tbody>
        </table>
    </form>
   <script type="text/javascript">
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
                str = str + '<td>' + data['d'][i]['name'] + '</td>'
                str = str + '<td>' + data['d'][i]['email'] + '</td>'
                str = str + '<td>' + data['d'][i]['college'] + '</td>'
                str = str + '<td>' + data['d'][i]['branch'] + '</td>'
                str = str + '<td>' + data['d'][i]['degree'] + '</td>'
                str = str + '<td>' + data['d'][i]['branch_ddl'] + '</td>'
                str = str + '</tr>';
            }
            $('#tbody').append(str);
        },
        error: function (xhr, status, error) {
            console.log(xhr+status+error);
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
   </script>
</body>
</html>
