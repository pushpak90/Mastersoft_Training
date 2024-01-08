<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
</head>
<body class="bg-img">
    <div>
        <div class="registration-form">
            <form class="A1" id="form1" runat="server">
                <div class="A1"></div>
                <div class="registration-logo with-border">
                    <h1><b>Login Form</b></h1>
                </div>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtUserName" runat="server" class="form-control item" placeholder="Enter User Name"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtPassword" runat="server" class="form-control item" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                </div>

                
                <div class="row">
                    <div class="col-md-12">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" class="btn btn-block login-button"  />
                    </div>
                </div>
                
            </form>
        </div>

    </div>
</body>
</html>
