<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebApplication1.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
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
                            <asp:TextBox ID="txtId" runat="server" class="form-control item" placeholder="Enter ID"  ></asp:TextBox>
						</div>
					</div>
                    
					<div class="col-md-6">
						<div class="form-group">
                            <asp:TextBox ID="txtName" runat="server" class="form-control item" placeholder="Enter Name"  ></asp:TextBox>
						</div>
					</div>
				</div>
                
				<div class="row">
					<div class="col-sm-12">
						<div>
                            <asp:TextBox runat="server"  id="txtEmail" placeholder="Enter Email" class="form-control item"></asp:TextBox>
						</div>
					</div>
				</div>
                   
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
							<asp:TextBox ID="txtAddress" runat="server" class="form-control item" placeholder="Enter Address"></asp:TextBox>
							<!-- <select class="countrypicker form-control item"></select> -->
						</div>
					</div>
					<div class="col-md-6">
						<div class="form-group">
							<asp:TextBox ID="txtPin" runat="server" class="form-control item" placeholder="Enter Pin"></asp:TextBox>
						</div>
					</div>
				</div>
                <div class="row">
					<div class="col-md-3">
						<div class="form-group">
							Upload File : 
						</div>
					</div>
					<div class="col-md-9">
						<div class="form-group">
							<asp:FileUpload ID="FileUpload1" runat="server" />
						</div>
					</div>
				</div>
				<div class="row">
					<div class="col-md-4">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-block login-button" OnClick="btnSubmit_Click"/>
					</div>
                    <div class="col-md-4">
                        <asp:Button ID="btnUpdate" runat="server" class="btn btn-block login-button" Text="Update" OnClick="btnUpdate_Click" />
					</div>
					<div class="col-md-4">
                        <asp:Button ID="btnNext" runat="server" Text="Next" class="btn btn-block login-button" OnClick="btnNext_Click"/>
					</div>
				</div>
                </form>
            </div>
        </div>
</body>
</html>
