<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="message.aspx.cs" Inherits="Assignment_1.message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Information -
            <br />
            <br />
            Name :
            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Personal Email :
            <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Pin Code :
            <asp:Label ID="lblPin" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Company Email :
            <asp:Label ID="lblCemail" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Mobile Number :
            <asp:Label ID="lblMobile" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Password :
            <asp:Label ID="lblPassword"  runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
