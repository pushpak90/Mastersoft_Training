<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="36px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="111px">
                <asp:ListItem>PG</asp:ListItem>
                <asp:ListItem>UG</asp:ListItem>
            </asp:DropDownList>
            <br />
        </div>
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
    </form>
</body>
</html>
