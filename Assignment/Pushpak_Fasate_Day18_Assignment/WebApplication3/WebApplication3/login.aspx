<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication3.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div
            <h1>Login</div>
        <p>
            Email :
            <asp:TextBox ID="t_email" runat="server"></asp:TextBox>
        </p>
        <p>
            password :
            <asp:TextBox ID="t_password" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />
    </form>
</body>
</html>
