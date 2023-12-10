

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="preview.aspx.cs" Inherits="WebApplication2.preview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .div1{
            position:absolute;
        }
        .img{
            width:100%;
            height:100vh;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div CssClass="div1">
            <asp:Image ID="Image1" CssClass="img" runat="server" Height="894px" Width="1443px" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
