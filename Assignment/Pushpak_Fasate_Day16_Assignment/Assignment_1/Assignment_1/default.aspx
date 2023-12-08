<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Assignment_1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Assigment 1</h1>
        </div>
        <p>
            Enter Username :
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter Date :
            <asp:TextBox ID="date" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="submit" runat="server" OnClick="Button1_Click" Text="Submit" />
        </p>
        <p>
            <asp:Label ID="output1" runat="server" Text="Label"></asp:Label>
        </p>
        <a href="contact.aspx">Click Here</a>
    </form>
</body>
</html>
