<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="f_upload.aspx.cs" Inherits="WebApplication1.f_upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            File Upload Implementation :<br />
            <br />
            upload your photo
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
        <br />
        <asp:Image ID="Image1" runat="server" Height="294px" Width="280px" />
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
