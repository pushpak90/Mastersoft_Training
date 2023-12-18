<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Assignment_4._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name :
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Enter Name* ">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Enter College :
            <asp:TextBox ID="txtCollege" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCollege" ErrorMessage="Enter College*">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Enter Subject :
            <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSubject" ErrorMessage="Enter Subject*">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Enter Branch : <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtBranch" ErrorMessage="Enter Branch*">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Enter Percentage :
            <asp:TextBox ID="txtPer" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPer" ErrorMessage="Enter Percentage*">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <br />
            <br />
        </div>
        <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblPer" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lblGarde" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
