<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exam.aspx.cs" Inherits="Assignment4.exam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>Education Details</center>
        </div>
        <p>
            Name :
            <asp:Label ID="l_name1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Email :
            <asp:Label ID="l_email1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Mobile : <asp:Label ID="l_mobile1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Select Branch : 
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>CSE</asp:ListItem>
                <asp:ListItem>IT</asp:ListItem>
                <asp:ListItem>ETC</asp:ListItem>
                <asp:ListItem>ETRX</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Select Semister : 
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
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
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Morning Shift</asp:ListItem>
                <asp:ListItem>Evening Shift</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
