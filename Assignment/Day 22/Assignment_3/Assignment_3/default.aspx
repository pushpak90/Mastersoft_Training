<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Assignment_3._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <h1>Add Information</h1>
            <br />
            Enter Name :
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name*" ControlToValidate="txtName">*</asp:RequiredFieldValidator>
        <p>
            Enter City :
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter City*" ControlToValidate="txtCity">*</asp:RequiredFieldValidator>
        </p>
        <p>
            Enter College :
            <asp:TextBox ID="txtCollege" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter College*" ControlToValidate="txtCollege">*</asp:RequiredFieldValidator>
        </p>
        <p>
            Enter Branch :
            <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Branch*" ControlToValidate="txtCollege">*</asp:RequiredFieldValidator>
        </p>
        <p>
            Enter Percentage :
            <asp:TextBox ID="txtPer" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Percent*" ControlToValidate="txtPer">*</asp:RequiredFieldValidator>
        </p>
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <p>
        <h1>Result :</h1>

        <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lblgrade" runat="server" Text="Label"></asp:Label>
    </p>
    </form>
    </body>
</html>
