<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Drop Down List : </h1>
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="34px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="173px">
            <asp:ListItem>Nagpur</asp:ListItem>
            <asp:ListItem>Mumbai</asp:ListItem>
            <asp:ListItem>Pune</asp:ListItem>
            <asp:ListItem>Nashik</asp:ListItem>
            <asp:ListItem>Delhi</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="33px" OnClick="Button1_Click" Text="Add" Width="99px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="31px" OnClick="Button2_Click" Text="Clear" Width="83px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="33px" OnClick="Button3_Click" Text="Fix Data Value" Width="126px" />
        <p>
            <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click" /><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Insert" />
        </p>

    </form>
</body>
</html>
