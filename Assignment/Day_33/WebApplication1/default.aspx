<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <br />
            <br />
            Id -
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <br />
            Product Name -
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            Cost -
            <asp:TextBox ID="txtCost" runat="server"></asp:TextBox>
            <br />
            Upload Photo -
            <asp:FileUpload ID="FileUpload1" runat="server" accept=".png,.jpg,.jpeg,.gif"/>
            <br />
            Sell Cost -
            <asp:TextBox ID="txtSellcost" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
            <br />

        </div>
        <asp:Button ID="Button3" runat="server" Text="Display" OnClick="Button3_Click" />
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="5" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand">
            <ItemTemplate>
                <b>Product Photo : <asp:Image ID="Image1" ImageUrl='<%# Eval("Photo", "~/upload/{0}") %>' runat="server" Height="100px" Width="100px" /></b><br/>
                <b>Product Name : <asp:Label ID="lblName" runat="server" Text='<%# Eval("Prodname") %>'></asp:Label></b><br/>
                <b>Cost : <asp:Label ID="lblCost" runat="server" Text='<%# Eval("Cost") %>'></asp:Label></b><br/>
                <b>Enter Your Cost : <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></b>
                <asp:Button ID="Button4" runat="server" Text="Buy Now" CommandName="buy"/>
            </ItemTemplate>
        </asp:DataList>


        </div>
    </form>
</body>
</html>
