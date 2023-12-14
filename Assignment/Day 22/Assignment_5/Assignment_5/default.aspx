<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Assignment_5._default" %>

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
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Enter Name*"></asp:RequiredFieldValidator>
            <br />
            <br />
            Enter City :
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCity" ErrorMessage="Enter City*"></asp:RequiredFieldValidator>
            <br />
            <br />
            Enter College :
            <asp:TextBox ID="txtCollege" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCollege" ErrorMessage="Enter College*"></asp:RequiredFieldValidator>
            <br />
            <br />
            Enter Mark 1 :
            <asp:TextBox ID="txtMark1" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtMark1" ErrorMessage="Enter 1 to 100*" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
            Enter Mark 2 :
            <asp:TextBox ID="txtMark2" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtMark2" ErrorMessage="Enter 0 to 100" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
            Enter Mark 3 :
            <asp:TextBox ID="txtMark3" runat="server"></asp:TextBox><asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage="Enter 1 to 100*" MaximumValue="100" MinimumValue="1" Type="Integer" ControlToValidate="txtMark3"></asp:RangeValidator>
            <br />
            <br />
            Enter Mark 4 :
            <asp:TextBox ID="txtMark4" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtMark4" ErrorMessage="Enter 1 to 100*" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
            Enter Mark 5 :
            <asp:TextBox ID="txtMark5" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="txtMark5" ErrorMessage="Enter 1 to 100*" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit " OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="lblDsiplay" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblGrade" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
