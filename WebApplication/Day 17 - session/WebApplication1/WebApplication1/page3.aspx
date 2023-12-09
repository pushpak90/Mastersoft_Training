<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page3.aspx.cs" Inherits="WebApplication1.page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Radio Button Implimentation</h3>
        </div>
        <p>
            Online student examination :</p>
        <p>
            Question 1 : Ineteger Accept
        </p>
        <p>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>all</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Question 2 : Boolean Store</p>
        <p>
            <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                <asp:ListItem>Num</asp:ListItem>
                <asp:ListItem>True/False</asp:ListItem>
                <asp:ListItem>all</asp:ListItem>
                <asp:ListItem>null</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Score" Height="29px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
