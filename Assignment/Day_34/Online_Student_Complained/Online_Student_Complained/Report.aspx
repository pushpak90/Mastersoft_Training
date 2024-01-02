<%@ Page Title="" Language="C#" MasterPageFile="~/Collegeadmin.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="Online_Student_Complained.Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Report.aspx</h1>
    Select Department <asp:DropDownList ID="ddldeptdrop" runat="server"></asp:DropDownList>
    <br />
    <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
    <br />
    <asp:Button ID="btnFindAll" runat="server" Text="Find All" OnClick="btnFindAll_Click" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="SNO">
                    <ItemTemplate>
                        <%# Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="College code">
                    <ItemTemplate>
                        <asp:Label ID="lblColcode" runat="server" Text='<%# Eval("Collegecode") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="Student Name">
                    <ItemTemplate>
                    <asp:Label ID="lblSname" runat="server" Text='<%# Eval("Sname") %>'></asp:Label>
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email ID">
                    <ItemTemplate>
                        <asp:Label ID="lblEmail" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Department">
                    <ItemTemplate>
                        <asp:Label ID="lblDept" runat="server" Text='<%# Eval("Branch") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Complain To">
                    <ItemTemplate>
                        <asp:Label ID="lblcomplain" runat="server" Text='<%# Eval("Complainto") %>' ></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Message">
                    <ItemTemplate>
                       <asp:Label ID="lblMessage" runat="server" Text='<%# Eval("msg") %>' ></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Resolved By">
                    <ItemTemplate>
                        <asp:DropDownList ID="ddlResolve" runat="server"></asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:DropDownList ID="ddlStatus" runat="server">
                            <asp:ListItem>SELECT</asp:ListItem>
                                <asp:ListItem>CLOSE</asp:ListItem>
                                <asp:ListItem>PENDING</asp:ListItem>
                                <asp:ListItem>FORWORD</asp:ListItem>
                                
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action">
                     <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            
        <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
</asp:Content>
