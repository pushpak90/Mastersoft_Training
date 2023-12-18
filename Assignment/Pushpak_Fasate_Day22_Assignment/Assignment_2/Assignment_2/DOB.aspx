<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DOB.aspx.cs" Inherits="Assignment_2.DOB" %>

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
            Select Date of Birth :
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Age is :
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCal" runat="server" OnClick="Button1_Click" Text="Calculate Age" />
        </p>
    </form>
</body>
</html>
