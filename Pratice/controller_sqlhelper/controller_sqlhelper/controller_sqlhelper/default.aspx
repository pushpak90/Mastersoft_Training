<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="controller_sqlhelper._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            First Name :
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            Last Name :
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            College :
            <asp:TextBox ID="txtCollege" runat="server"></asp:TextBox>
            <br />
            Select Branch :
            <asp:DropDownList ID="ddlBranch" runat="server">
            </asp:DropDownList>
            <br />
            Mobile No :
            <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />

        </div>
    </form>
</body>
</html>
