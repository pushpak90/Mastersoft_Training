<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebApplication3.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Registration Form : 
        </div>

        <p>
            Name :
            <asp:TextBox ID="t_name" runat="server"></asp:TextBox>
        </p>
        <p>
            Email :
            <asp:TextBox ID="t_email" runat="server"></asp:TextBox>
        </p>
        <p>
            Mobile :
            <asp:TextBox ID="t_mobile" runat="server"></asp:TextBox>
        </p>
        <p>
            Password :&nbsp;
            <asp:TextBox ID="t_password" runat="server"></asp:TextBox>
        </p>
        <p>
            Date :&nbsp;
            <asp:TextBox ID="t_date" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </p>

    </form>
</body>
</html>
