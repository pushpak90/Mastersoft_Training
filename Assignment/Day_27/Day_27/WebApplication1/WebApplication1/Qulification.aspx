<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Qulification.aspx.cs" Inherits="WebApplication1.Qulification" %>

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
                    <h1><b>Registration Form</b></h1>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtId" runat="server" class="form-control item" placeholder="Enter ID"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:DropDownList ID="ddlDegree" runat="server" class="form-control item">
                                <asp:ListItem>Select Degree</asp:ListItem>
                                <asp:ListItem>UG</asp:ListItem>
                                <asp:ListItem>PG</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtUG" runat="server" class="form-control item" placeholder="Enter UG Name"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtPG" runat="server" class="form-control item" placeholder="Enter PG Name"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="YOP Between 2012 to 2016" ControlToValidate="txtYear" MaximumValue="2016" MinimumValue="2012"></asp:RangeValidator>
                            <asp:TextBox ID="txtYear" runat="server" class="form-control item" placeholder="Enter YOP PG"></asp:TextBox>
                            <!-- <select class="countrypicker form-control item"></select> -->
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
