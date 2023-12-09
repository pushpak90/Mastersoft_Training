<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="WebApplication1.page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome User
            <br />
            Email :
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            Mobile :
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            Enter Branch :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <p>
            Enter Sub :
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" />
    </form>
</body>
</html>
