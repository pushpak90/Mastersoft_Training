<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="controller_sqlhelper._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<script src="jquery-3.7.1.min.js"></script>--%>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            First Name :
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            Last Name :
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            College :
            <asp:TextBox ID="txtCollege" runat="server"></asp:TextBox>
            <br />
            Select Degree:
            <asp:DropDownList ID="ddlDegree" runat="server">
            </asp:DropDownList>
            Select Branch:
            <asp:DropDownList ID="ddlBranch" runat="server">
            </asp:DropDownList>
            <br />
            Mobile No :
            <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <button type="button" id="btnSubmit">Click Me!</button>

        </div>
    </form>
    <script src="<%=Page.ResolveClientUrl("~/JavaScript.js")%>"></script>
</body>
</html>
