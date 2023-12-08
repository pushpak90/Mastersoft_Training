<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Assignment_2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>Assigment 2</header>
        </div>
        <p>
            Select Country :
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>US</asp:ListItem>
                <asp:ListItem>Aus</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Select State :
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem>Select</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Select City :
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
                <asp:ListItem>Select</asp:ListItem>
            </asp:DropDownList>
        </p>
    </form>
</body>
</html>
