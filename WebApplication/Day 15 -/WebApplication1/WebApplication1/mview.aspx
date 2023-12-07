<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mview.aspx.cs" Inherits="WebApplication1.mview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Contain Management System</h1>
        </div>
        <asp:Button ID="Button1" runat="server" Text="C Programming" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text=".NET" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="java" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Python" OnClick="Button4_Click" />
        <br />
        <br />
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                C programming Language<br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </asp:View>
            <asp:View ID="View2" runat="server">
                .Net Framework<br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </asp:View>
            <asp:View ID="View3" runat="server">
                Java Programming Language<br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </asp:View>
            <asp:View ID="View4" runat="server">
                Python Programming Language<br />
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </asp:View>
        </asp:MultiView>
    </form>
</body>
</html>
