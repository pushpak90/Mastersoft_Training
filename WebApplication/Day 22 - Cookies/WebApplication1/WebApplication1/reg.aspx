<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="WebApplication1.reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Enter Email :
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Enter Mobile :
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Number is not valid " ValidationExpression="^\+91[0-9]{10}"></asp:RegularExpressionValidator>
            <br />
            Enter Sub<span lang="EN-US" style="font-size:11.0pt;line-height:
107%;font-family:&quot;Calibri&quot;,sans-serif;mso-ascii-theme-font:minor-latin;
mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-hansi-theme-font:
minor-latin;mso-bidi-font-family:&quot;Times New Roman&quot;;mso-bidi-theme-font:minor-bidi;
mso-ansi-language:EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">ject : </span>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            Mark1 :
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            Mark 2 :
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            Mark 3 :
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            Mark 4 :
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            Mark 5 :
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <br />
            Total :
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            <br />
            Grade :
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Subject" />
            <br />
            <br />
            Select Your Date :
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
