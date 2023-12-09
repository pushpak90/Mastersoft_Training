<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="WebApplication1.page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Page 2:</h1>
        </div>

        <p>
            Name :
            <asp:Label ID="l_name" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Email :
            <asp:Label ID="l_email" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            City :
            <asp:Label ID="l_city" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Branch :
            <asp:TextBox ID="t_branch" runat="server"></asp:TextBox>
        </p>
        <p>
            Subject : <asp:TextBox ID="t_sub" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" />
        </p>

    </form>
</body>
</html>
