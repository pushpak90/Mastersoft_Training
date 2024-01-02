<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stulogin.aspx.cs" Inherits="Online_Student_Complained.stulogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Style.css" />
</head>
<body>
    
    <div class="form_wrapper">
    <div class="form_container">
        <div class="title_container">
            <h2>Student Login</h2>
        </div>
        <div class="row clearfix">
            <div class="">
                <form id="form2" runat="server">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Email" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email" ControlToValidate="txtEmail" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"></asp:RegularExpressionValidator>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter Email" on></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Password" ControlToValidate="txtPasswrod"></asp:RequiredFieldValidator>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtPasswrod" runat="server" placeholder="Enter Password" class="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnLogin" class="button" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    <br />
                    <asp:Button ID="btnNew" class="button" runat="server" Text="New Account" OnClick="btnNew_Click" CausesValidation="false"/>
                </form>
            </div>
        </div>
    </div>
</div>
      
</body>
</html>
