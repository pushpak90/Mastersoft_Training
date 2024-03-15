<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Value="1">NIT</asp:ListItem>
                <asp:ListItem Value="2">GNIT</asp:ListItem>
                <asp:ListItem Value="3">Palotii</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>

            <div>
                <input type="button" value="Report" id="btnReport"/>
            </div>
        </div>
    </form>
    <script src="<%=Page.ResolveClientUrl("~/JavaScript.js")%>"></script> 
</body>
</html>
