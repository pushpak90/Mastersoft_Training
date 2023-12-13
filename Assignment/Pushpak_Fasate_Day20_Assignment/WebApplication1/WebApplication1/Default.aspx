<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="Style.css" />
</head>
<body>
    <div class="wrapper">
    <form id="form1" runat="server">
        
            
            <h2>Registration Form</h2>
        <p>
            <div class="input-box">
            <asp:TextBox placeholder="Name" ID="t_name" runat="server" class="tlable"></asp:TextBox>
                </div>
        </p>
        <p>
            <div class="input-box">
            <asp:TextBox  placeholder="Enter Email ID :" ID="t_email" runat="server" class="tlable"></asp:TextBox>
                </div>
        </p>
        <p>
            <asp:TextBox placeholder="Enter Password :"  ID="t_password" runat="server" class="tlable"></asp:TextBox>
        </p>
        <p>
            <div class="input-box">
            <asp:TextBox placeholder="Enter Mobile :" ID="t_mobile" runat="server" class="tlable"></asp:TextBox>
                </div>
        </p>
        <p>
            <div class="input-box">
            <asp:FileUpload placeholder="Upload Photo :" class="btn" ID="img" runat="server" accept=".png,.jpg,.jpeg,.gif"/>
                </div>
        </p>
        <p>
            <div class="input-box">
            <asp:TextBox  ID="T_date" runat="server" class="tlable"></asp:TextBox>
                </div>
        </p>
        <p>
            <asp:Button ID="Btn_login" class="btn" runat="server" Text="Login Button" OnClick="Btn_login_Click" />
        </p>
                
         
       
    </form>
       </div>
</body>
</html>
