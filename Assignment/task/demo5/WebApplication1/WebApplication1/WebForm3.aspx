<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {
            $('#btnName').click(function () {
                var email = $('#txtName').val();
                if ($('#txtName').val() == "") {
                    alert("Enter Your Email.");
                }
                
            })
        })

        //^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Enter Name : </label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnName" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
