<%@ Page Title="" Language="C#" MasterPageFile="~/deptmaster.Master" AutoEventWireup="true" CodeBehind="depmarkreport.aspx.cs" Inherits="WebApplication1.depmarkreport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Depmarkreport</h1>
    
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID"></asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="Name"></asp:BoundField>
            <asp:BoundField DataField="Dept" HeaderText="Dept"></asp:BoundField>
            <asp:BoundField DataField="Activityname" HeaderText="Activity Name"></asp:BoundField>
            <asp:BoundField DataField="OrgName" HeaderText="Org Name"></asp:BoundField>
            <asp:BoundField DataField="Mark" HeaderText="Mark"></asp:BoundField>
        </Columns>
    </asp:GridView>

</asp:Content>
