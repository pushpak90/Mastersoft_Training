<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Implementing Query String.</h1>
        </div>
        
        <p>
            Enter Name :
            <asp:TextBox ID="t_name" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter Email :<asp:TextBox ID="t_email" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter City :
            <asp:TextBox ID="t_city" runat="server"></asp:TextBox>
        </p>
        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />
        
    </form>
</body>
</html>
