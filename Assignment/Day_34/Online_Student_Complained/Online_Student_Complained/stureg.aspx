<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stureg.aspx.cs" Inherits="Online_Student_Complained.stureg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class="form_wrapper">
        <div class="form_container">
            <div class="title_container">
                <h2>College Registration</h2>
                <link rel="stylesheet" type="text/css" href="Style.css" />
            </div>
            <div class="row clearfix">
                <div class="">
                    <form id="form2" runat="server">
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:DropDownList runat="server" ID="ddlcol" ></asp:DropDownList>
                        </div>
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtname" runat="server" placeholder="Enter Student Name "></asp:TextBox>
                        </div>
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:DropDownList runat="server" ID="ddlb" ></asp:DropDownList>
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
                            <asp:TextBox ID="txtSem" runat="server" placeholder="Enter Semister"></asp:TextBox>
                        </div>
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtpassword" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtDate" runat="server" placeholder="Date"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnSubmit" class="button" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
                        <br />
                        <asp:Button ID="btnLogin" class="button" runat="server" Text="Login" OnClick="btnLogin_Click"/>
                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
