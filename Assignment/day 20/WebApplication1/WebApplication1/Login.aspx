<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="Style.css" />
</head>
<body>
    
        <div>
        </div>
        

        <div class="wrapper">
            <form id="form1" runat="server">
            <h2><center>Login</center></h2>
        <p>
            <div class="input-box">
            
            <asp:TextBox ID="t_email" placeholder="Enter Email" runat="server" class="tlable"></asp:TextBox>
                </div>
        </p>
        <p>
             <div class="input-box">
            <asp:TextBox ID="t_password" placeholder="Enter Password" runat="server" class="tlable"></asp:TextBox>
                 </div>
        </p>
        <p>
            <asp:Button ID="Button1" class="btn" runat="server" Text="Login" OnClick="Button1_Click" />
             </form>
            </div>
   
</body>
</html>
