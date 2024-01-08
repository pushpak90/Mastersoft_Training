<%@ Page Title="" Language="C#" MasterPageFile="~/dash.Master" AutoEventWireup="true" CodeBehind="vendor.aspx.cs" Inherits="WebApplication1.vendor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Vendor Registration Form : </h1>
    ID : <asp:TextBox ID="txtId" runat="server"></asp:TextBox><br />
    Vendor Name : <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
    City : <asp:DropDownList ID="ddlCity" runat="server"></asp:DropDownList><br />
    Address : <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br />
    Mobile No. : <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Button" /><br /><br />
    <asp:Button ID="Button2" runat="server" Text="Button" />
</asp:Content>
