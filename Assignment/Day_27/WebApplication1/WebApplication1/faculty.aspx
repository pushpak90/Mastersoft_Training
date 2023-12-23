<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="faculty.aspx.cs" Inherits="WebApplication1.faculty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link rel="stylesheet" href="Style.css" type="text/css" />
	 <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
</head>
<body class="bg-img">
        <div>
            <div class="registration-form">
                <form class="A1" id="form1" runat="server">
                    <div class="registration-logo with-border">
					    <h1><b>Registration Form</b></h1>
				    </div>
                    <div class="row">
					<div class="col-md-12">
						<div class="form-group">
                            <asp:TextBox ID="txtEmail" runat="server" class="form-control item" placeholder="Enter Email"  ></asp:TextBox>
						</div>
					</div>
						</div>
                  
					<div class="row">
					<div class="col-md-12">
						<div class="form-group">
                            <asp:TextBox ID="txtPassword" runat="server" class="form-control item" placeholder="Enter Password" TextMode="Password" ></asp:TextBox>
						</div>
					</div>
				</div>
				<div class="row">
					<div class="col-md-12">
                        <asp:Button ID="btnSubmit" runat="server" Text="Login" class="btn btn-block login-button" OnClick="btnSubmit_Click" />
					</div>
                                   
				</div>
                </form>
            </div>
        </div>
</body>
</html>
