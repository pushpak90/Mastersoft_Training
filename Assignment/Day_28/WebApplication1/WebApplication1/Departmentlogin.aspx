<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Departmentlogin.aspx.cs" Inherits="WebApplication1.Departmentlogin_aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Style.css" />
</head>
<body>
        <div>
            <div class="form_wrapper">
        <div class="form_container">
            <div class="title_container">
                <h2>Faculty Login</h2>
            </div>
            <div class="row clearfix">
                <div class="">
                    <form id="form2" runat="server">
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter Faculti ID"></asp:TextBox>
                        </div>
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtPasswrod" runat="server" placeholder="Enter Password" class="form-control" TextMode="Password"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnLogin" class="button" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </form>
                </div>
            </div>
        </div>
    </div>
        </div>
 
</body>
</html>
