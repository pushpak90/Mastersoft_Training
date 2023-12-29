<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>CURD Operation</h1>
            Enter Roll : <asp:TextBox ID="txtRoll" runat="server"></asp:TextBox>&nbsp;&nbsp; <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
            <br />
            Enter Name : <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            Enter City : <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
&nbsp;&nbsp;
            <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Roll" HeaderText="Roll No." />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="City" HeaderText="City" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
