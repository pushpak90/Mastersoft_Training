<%@ Page Title="" Language="C#" MasterPageFile="~/deptmaster.Master" AutoEventWireup="true" CodeBehind="Deptmark.aspx.cs" Inherits="WebApplication1.Deptmark" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="gride">
        <h1>Deptmark</h1>
       <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br/>
            Name : <asp:TextBox ID="txtName" runat="server"></asp:TextBox><asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <br/>Update Mark : <asp:Button ID="mark" runat="server" Text="Update Mark" OnClick="mark_Click" />
            <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="Student ID" />
                <asp:BoundField DataField="Name" HeaderText="Student Name" />
                <asp:BoundField DataField="Dept" HeaderText="DEPT" />
                <asp:BoundField DataField="Activity" HeaderText="Activity"></asp:BoundField>
                <asp:BoundField DataField="Org" HeaderText="Org"></asp:BoundField>
                <asp:TemplateField HeaderText="Mark">
                    <ItemTemplate>
                        <asp:TextBox ID="txtmark" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
