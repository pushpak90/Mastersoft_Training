<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="Style.css" />
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
                            <asp:TextBox ID="txtRoll" runat="server" class="form-control item" placeholder="Enter Roll Number"  ></asp:TextBox>
						</div>
					</div>
                    <!--<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Only Alphabet" ControlToValidate="txtName" ValidationExpression="[a-zA-Z]"></asp:RegularExpressionValidator>-->
					<div class="col-md-6">
						<div class="form-group">
                            <asp:TextBox ID="txtName" runat="server" class="form-control item" placeholder="Enter Name"  ></asp:TextBox>
						</div>
					</div>
				</div>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email is improper" ControlToValidate="txtEmail" ValidationExpression="^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$"></asp:RegularExpressionValidator>
				<div class="row">
					<div class="col-sm-12">
						<div>
                            <asp:TextBox runat="server"  id="txtEmail" placeholder="Enter Email" class="form-control item"></asp:TextBox>
						</div>
					</div>
				</div>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Incorrect Number" ValidationExpression="^\+91[0-9]{10}" ControlToValidate="txtMobile"></asp:RegularExpressionValidator>
				<div class="row">
					<div class="col-md-6">
						<div class="form-group">
                            <asp:TextBox ID="txtMobile" runat="server" class="form-control item" placeholder="Enter Mobile"></asp:TextBox>
						</div>
					</div>
					<div class="col-md-6">
						<div class="form-group">
							
                            <asp:DropDownList ID="ddlCity" runat="server" class="form-control " placeholder="Select City">
                                <asp:ListItem>SelectCity</asp:ListItem>
                                <asp:ListItem>Nagpur</asp:ListItem>
                                <asp:ListItem>Pune</asp:ListItem>
                                <asp:ListItem>Mumbai</asp:ListItem>
                            </asp:DropDownList>
						</div>
					</div>
				</div>
				<div class="row">
					<div class="col-md-6">
						<div class="form-group">
                            <asp:DropDownList ID="ddlSubject" runat="server" class="form-control " placeholder="Select Subject">
                                <asp:ListItem>SelectSubject</asp:ListItem>
                                <asp:ListItem>CSE</asp:ListItem>
                                <asp:ListItem>Civil</asp:ListItem>
                                <asp:ListItem>IT</asp:ListItem>
                            </asp:DropDownList>
						</div>
					</div>
					<div class="col-md-6">
						<div class="form-group">
                            <asp:TextBox ID="txtMark1" runat="server" class="form-control item" placeholder="Enter Mark 1"></asp:TextBox>
						</div>
					</div>
				</div>
				<div class="row">
					<div class="col-md-6">
						<div class="form-group">
							<asp:TextBox ID="txtMark2" runat="server" class="form-control item" placeholder="Enter Mark 2"></asp:TextBox>
							<!-- <select class="countrypicker form-control item"></select> -->
						</div>
					</div>
					<div class="col-md-6">
						<div class="form-group">
							<asp:TextBox ID="txtMark3" runat="server" class="form-control item" placeholder="Enter Mark 3"></asp:TextBox>
						</div>
					</div>
				</div>
				<div class="row">
					<div class="col-md-6">
						<div class="form-group">
							<asp:TextBox ID="txtMark4" runat="server" class="form-control item" placeholder="Enter Mark 4"></asp:TextBox>
						</div>
					</div>
					<div class="col-md-6">
						<div class="form-group">
							<asp:TextBox ID="txtMark5" runat="server" class="form-control item" placeholder="Enter Mark 5"></asp:TextBox>
						</div>
					</div>
				</div>
                    <div class="row">
					<div class="col-md-6">
						<div class="form-group">
							<asp:TextBox ID="txtTotal" runat="server" class="form-control item" placeholder="Total"></asp:TextBox>
						</div>
					</div>
					<div class="col-md-6">
						<div class="form-group">
							<asp:TextBox ID="txtGrade" runat="server" class="form-control item" placeholder="Grade "></asp:TextBox>
						</div>
					</div>
				</div>
				<div class="row">
					<div class="col-md-3">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-block login-button" OnClick="btnSubmit_Click"/>
					</div>
                    <div class="col-md-3">
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-block login-button" OnClick="btnUpdate_Click"/>
					</div>
                    <div class="col-md-3">
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-block login-button" OnClick="btnDelete_Click"/>
					</div>
                    <div class="col-md-3">
                        <asp:Button ID="btnFind" runat="server" Text="Find" class="btn btn-block login-button" OnClick="btnFind_Click"/>
					</div>
				</div>
                </form>
            </div>
        </div>
</body>
</html>
