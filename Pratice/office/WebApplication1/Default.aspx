<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:RadioButton ID="RadioButton1" runat="server" Value="1" Text="Original Selection" OnCheckedChanged="RadioButton1_CheckedChanged" AutoPostBack="true"/>
            <asp:RadioButton ID="RadioButton2" runat="server" Value="2" Text="Filter Selection " OnCheckedChanged="RadioButton2_CheckedChanged" AutoPostBack="true"/><br />
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList><br />
            <asp:TextBox ID="TextBox1" runat="server" type="date"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList><br />
        </div>
    </form>
</body>
</html>
