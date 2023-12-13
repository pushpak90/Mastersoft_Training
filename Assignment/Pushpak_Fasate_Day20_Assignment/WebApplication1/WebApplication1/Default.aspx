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
            <asp:TextBox placeholder="Name" ID="txtName" runat="server" class="tlable" ControlToValidate="txtName"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name*" ControlToValidate="txtName" ForeColor="White"></asp:RequiredFieldValidator>
                </div>
        </p>
        <p>
            <div class="input-box">
            <asp:TextBox  placeholder="Enter Email ID :" ID="txtEmail" runat="server" class="tlable" ControlToValidate="txtemail"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Email*" CausesValidation="True" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                </div>
        </p>
        <p>
            <asp:TextBox placeholder="Enter Password :"  ID="txtPassword" runat="server" class="tlable"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Password*" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
        </p>
        <p>
            <div class="input-box">
            <asp:TextBox placeholder="Enter Mobile :" ID="txtMobile" runat="server" class="tlable"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Mobile Number*" ControlToValidate="txtMobile"></asp:RequiredFieldValidator>
                </div>
        </p>
        <p>
            <div class="input-box">
            <asp:FileUpload placeholder="Upload Photo :" class="btn" ID="img" runat="server" accept=".png,.jpg,.jpeg,.gif"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Upload Photo* " ControlToValidate="img"></asp:RequiredFieldValidator>
                </div>
        </p>
        <p>
            <div class="input-box">
            <asp:TextBox  ID="txtDate" runat="server" class="tlable"></asp:TextBox>
                
                </div>
        </p>
        <p>
            <asp:Button ID="Btn_login" class="btn" runat="server" Text="Login Button" OnClick="Btn_login_Click" />
        </p>
                
         
       
    </form>
       </div>
</body>
</html>
