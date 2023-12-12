<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exam.aspx.cs" Inherits="WebApplication3.exam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Education Details</h1>
        </div>
        <p>
            Name :
            <asp:Label ID="l_name" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Email :
            <asp:Label ID="l_email" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Mobile :
            <asp:Label ID="l_mobile" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
&nbsp;Select Branch :
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>CSE</asp:ListItem>
                <asp:ListItem>IT</asp:ListItem>
                <asp:ListItem>ETC</asp:ListItem>
                <asp:ListItem>ETRX</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Select Semester :
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Select Shift :
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Morning Shift</asp:ListItem>
                <asp:ListItem>Night Shift</asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" />
    </form>
</body>
</html>
