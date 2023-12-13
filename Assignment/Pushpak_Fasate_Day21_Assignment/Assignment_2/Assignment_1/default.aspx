<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Assignment_1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Registration Form</h3>
        </div>
        <label>Name : </label>
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <br />
        <label>Email : </label>
        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid Email" ControlToValidate="txtemail" ValidationExpression="^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$">*</asp:RegularExpressionValidator>
        <br />
        <br />
        <label>Pin Code : </label>
        <asp:TextBox ID="txtpin" runat="server"></asp:TextBox>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtpin" ErrorMessage="Invalid Pin Code " ValidationExpression="^[1-9]{1}[0-9]{5}">*</asp:RegularExpressionValidator>
        <br />
        <br />
        <label>Company Mail : </label>
        <asp:TextBox ID="txtcemail" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtcemail" ErrorMessage="Invalid Compnay Email" ValidationExpression="^[a-zA-Z0-9+_.-]+@[mastersoft.com]+$">*</asp:RegularExpressionValidator>
        <br />
        <br />
        <label>Mobile : </label>
        <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtphone" ErrorMessage="Invalid Number " ValidationExpression="^\+91[0-9]{10}">*</asp:RegularExpressionValidator>
        <br />
        <br />
        Password :
        <asp:TextBox ID="txtpassword" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
