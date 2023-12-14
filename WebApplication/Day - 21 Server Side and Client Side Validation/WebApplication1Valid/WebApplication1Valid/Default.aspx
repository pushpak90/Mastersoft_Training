<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1Valid.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Validation Control Implimentation
        </p>
        <p>
            Enter Your Name -
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />
        </p>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name Require"></asp:RequiredFieldValidator>
        </p>
        <p>
            Range Validator
        </p>
        <p>
            &nbsp;Enter Your age between 18 to 35 -
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Valid" />
        </p>
        <p>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="RangeValidator" MaximumValue="35" MinimumValue="18">Between 18 to 35</asp:RangeValidator>
        </p>
        <p>
            Regular Expression Validator</p>
        <p>
            Regular Expression Implimentaton
        </p>
        <p>
            Enter your mobile nummber :
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
        </p>
        <p>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="RegularExpressionValidator" ValidationExpression="/d(10)">Invaliad Mobile Number</asp:RegularExpressionValidator>
        </p>
        <p>
            Enter Email :
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="Valid" />
        </p>
        <p>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="Email is not valid" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"></asp:RegularExpressionValidator>
        </p>
        <p>
            Compare Validator implimentation
        </p>
        <p>
            Enter value_1&nbsp; -
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;first</p>
        <p>
            Retype value
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;Second</p>
        <p>
            <asp:Button ID="Button5" runat="server" Text="Valid" />
        </p>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox6" ControlToValidate="TextBox5" ErrorMessage="Does not match "></asp:CompareValidator>
    </form>
</body>
</html>
