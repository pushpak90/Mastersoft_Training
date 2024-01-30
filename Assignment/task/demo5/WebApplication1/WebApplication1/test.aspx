<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebApplication1.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script type="text/javascript">
        function valnum() {
            if (document.getElementById("<%= txt.ClientID %>").value == "") {
                alert("Empty 1");
            }
            var temp = parseInt(document.getElementById("<%= txt.ClientID %>").value)
            if (temp > 18)
            {
                alert("Empty 1");
            }
        }

        $(document).ready(function () {
            $("#Button1").click(function () {
                if ($("#TextBox1").val() == '') {
                    alert('Empty 2');
                }
            })
        })

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt" runat="server" placeholder="Enter Name"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name" ControlToValidate="txt"></asp:RequiredFieldValidator>
            <asp:Button ID="btn" runat="server" Text="text 1" OnClientClick="valnum()" OnClick="btn_Click" /><br />
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="text2" OnClick="Button1_Click" CausesValidation="false"/><br />

        </div>
    </form>
</body>
</html>
