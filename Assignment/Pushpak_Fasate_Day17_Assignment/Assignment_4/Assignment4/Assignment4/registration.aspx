<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="Assignment4.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>Registration Form</center>

        </div>
        <p>
            Name :
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
        </p>
        <p>
            Email :
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
        </p>
        <p>
            Mobile :
            <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
        </p>
        <p>
            Password :
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </p>
        <p>
            Date :
            <asp:TextBox ID="date" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
