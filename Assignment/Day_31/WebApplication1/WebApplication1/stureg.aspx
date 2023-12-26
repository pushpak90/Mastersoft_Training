<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stureg.aspx.cs" Inherits="WebApplication1._default" %>

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
                <h2>Registration Form</h2>
            </div>
            <div class="row clearfix">
                <div class="">
                    <form id="form1" runat="server">
                        <div class="row clearfix">
                            <div class="col_half">
                                <div class="input_field">
                                    <span><i aria-hidden="true" class="fa fa-user"></i></span>
                                    <asp:TextBox ID="txtId" runat="server" placeholder="Enter ID"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col_half">
                                <div class="input_field">
                                    <span><i aria-hidden="true" class="fa fa-user"></i></span>
                                    <asp:TextBox ID="txtName" runat="server" placeholder="Enter Name"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter Email"></asp:TextBox>
                        </div>
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:DropDownList ID="ddlBranch" runat="server" Height="35px" Width="100%">
                                <asp:ListItem>Selete Dept</asp:ListItem>
                                <asp:ListItem>CSE</asp:ListItem>
                                <asp:ListItem>IT</asp:ListItem>
                                <asp:ListItem>CIVIL</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtPassword" runat="server" placeholder="Enter Password" class="form-control" TextMode="Password"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnSubmit" class="button" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                        <asp:Button ID="btnLogin" class="button" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </form>
                </div>
            </div>
        </div>
    </div>
    <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>

</body>
</html>
