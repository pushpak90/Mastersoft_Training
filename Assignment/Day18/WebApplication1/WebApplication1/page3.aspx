<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page3.aspx.cs" Inherits="WebApplication1.page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Page 3</h1>
        </div>
        <p>
            Branch :
            <asp:Label ID="l_branch" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Subject :
            <asp:Label ID="l_sub" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            College :
            <asp:TextBox ID="t_col" runat="server"></asp:TextBox>
        </p>
        <p>
            Principal :
            <asp:TextBox ID="t_prin" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Finish" />
    </form>
</body>
</html>
