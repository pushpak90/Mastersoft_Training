<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product_view.aspx.cs" Inherits="WebApplication1.product_view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                User Price : <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        Photo : <asp:Image ID="Image1" ImageUrl='<%# Eval("Photo", "~/upload/{0}") %>' Height="100px" Width="100px" runat="server" /><br />
                        Product Id : '<%# Eval("Id") %>'<br />
                        Product Name : '<%# Eval("Prodname") %>'<br/>
                        Product Cost : '<%# Eval("Cost") %>'<br/>
                        Product Selling Cost : '<%# Eval("Sellcost") %>'<br/>
                        
                    </ItemTemplate>
                </asp:DataList>
        </div>
    </form>
</body>
</html>
