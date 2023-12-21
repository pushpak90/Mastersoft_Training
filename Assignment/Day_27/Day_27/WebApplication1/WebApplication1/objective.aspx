<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="objective.aspx.cs" Inherits="WebApplication1.objective" %>

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
                <div class="registration-logo with-border">
                    <h1><b>Registration Form</b></h1>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtId" runat="server" class="form-control item" placeholder="Enter ID"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="250 Word Only" ControlToValidate="txtObj" ValidationExpression="^[\s\S]{10,250}$"></asp:RegularExpressionValidator>
                            <asp:TextBox ID="txtObj" runat="server" class="form-control item" Height="200px" placeholder="Enter Objective"></asp:TextBox>
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
                        <asp:Button ID="btnFinish" runat="server" Text="Finish" class="btn btn-block login-button" OnClick="btnFinish_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
