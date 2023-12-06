<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Assignment 1:</h1>
            Enter Roll No.:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div><br />
            Enter Name : 
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
            Enter num 1 :
            
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br /><br />
        <asp:Button  ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <asp:Button Style="right: 500px" ID="Button2" runat="server" Text="Display" OnClick="Button2_Click" /><br /><br />
        Output : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <p id="outputscren" runat="server"></p>
    </form>
</body>
</html>
