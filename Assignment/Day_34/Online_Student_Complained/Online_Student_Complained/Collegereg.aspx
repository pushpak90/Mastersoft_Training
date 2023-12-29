﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Collegereg.aspx.cs" Inherits="Online_Student_Complained.Collegereg" %>

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
                <h2>College Registration</h2>
            </div>
            <div class="row clearfix">
                <div class="">
                    <form id="form2" runat="server">
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtCollegeName" runat="server" placeholder="Enter College Name : "></asp:TextBox>
                        </div>
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtCollegeCode" runat="server" placeholder="Enter College CODE"></asp:TextBox>
                        </div>
                         <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtPrincipal" runat="server" placeholder="Enter Principal Name"></asp:TextBox>
                        </div>
                         <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter Email"></asp:TextBox>
                        </div>
                         <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtMobile" runat="server" placeholder="Enter Mobile Number"></asp:TextBox>
                        </div>
                         <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtpassword" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
                        </div>
                         <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtDate" runat="server" placeholder="Date"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnSubmit" class="button" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                        <br />
                        <asp:Button ID="btnLogin" class="button" runat="server" Text="Login" OnClick="btnLogin_Click"/>
                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
