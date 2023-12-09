<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment4.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>Login Page</center>
        </div>
        <p>
            Enter Email :<asp:TextBox ID="l_email" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter Password :
            <asp:TextBox ID="l_password" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Exam" />
    </form>
</body>
</html>
