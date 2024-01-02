<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Email : <asp:TextBox ID="txtemail" runat="server"></asp:TextBox> <asp:Button ID="btnEmail" runat="server" Text="Send Email" OnClick="btnEmail_Click" />
          
            <br />
            Grid : 
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Roll"></asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="Name"></asp:BoundField>
                    <asp:BoundField DataField="City" HeaderText="City"></asp:BoundField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
