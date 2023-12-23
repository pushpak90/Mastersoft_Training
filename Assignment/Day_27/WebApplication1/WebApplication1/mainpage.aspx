<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainpage.aspx.cs" Inherits="WebApplication1.mainpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Style.css" />
</head>
<body>
    
        <div>
    <div class="registration-form">
        <form class="A1" id="form2" runat="server">
            <div class="registration-logo with-border">
			    <h1><b>Select Option </b></h1>
		    </div>
            <div class="row">
	<div class="col-md-12">
        <asp:Button ID="Button1" runat="server" Text="Student Registration" class="btn btn-block login-button" OnClick="Button1_Click" />
	</div>
                   
</div>
        
		<div class="row">
			<div class="col-md-12">
                <asp:Button ID="btnSubmit" runat="server" Text="Faculty Login" class="btn btn-block login-button" OnClick="btnSubmit_Click" />
			</div>
                           
		</div>
            </form>
    </div>
            </div>
</body>
</html>
