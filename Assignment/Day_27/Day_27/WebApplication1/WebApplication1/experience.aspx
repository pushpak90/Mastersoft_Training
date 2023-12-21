<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="experience.aspx.cs" Inherits="WebApplication1.experience" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
</head>
<body class="bg-img" style="background-color: lightblue">
    <div>
        <div class="registration-form">
            <form class="A1" id="form1" runat="server">
                <div class="registration-logo with-border">
                    <h1><b>Experience Info</b></h1>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtId" runat="server" class="form-control item" placeholder="Enter ID"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:DropDownList ID="ddlExp" runat="server" class="form-control item">
                                <asp:ListItem>Select Experience</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtComp" runat="server" class="form-control item" placeholder="Enter Name Of Company"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtOther" runat="server" class="form-control item" placeholder="Enter Other Exprence"></asp:TextBox>
                        </div>
                    </div>

                </div>

                <div class="row">

                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Calendar ID="Calendar1" runat="server" class="form-control item"></asp:Calendar>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-block login-button" OnClick="btnSubmit_Click" />
                    </div>
                    <div class="col-md-4">
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-block login-button" OnClick="btnUpdate_Click" />
                    </div>
                    <div class="col-md-4">
                        <asp:Button ID="btnNext" runat="server" Text="Next" class="btn btn-block login-button" OnClick="btnNext_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
