<%@ Page Title="" Language="C#" MasterPageFile="~/Collegeadmin.Master" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="Online_Student_Complained.Department" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form_wrapper">
        <div class="form_container">
            <div class="title_container">
                <h2>create Department</h2>
            </div>
            <div class="row clearfix">
                <div class="">
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtCode" runat="server" placeholder="Enter College ID/CODE" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtCollegename" runat="server" placeholder="Enter College" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtDept" runat="server" placeholder="Enter Dept"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnLogin" class="button" runat="server" Text="Submit" OnClick="btnLogin_Click" />
                    <br />
                    <asp:Button ID="btnNew" class="button" runat="server" Text="Show" OnClick="btnNew_Click" />
                    <br />
                    <asp:Button ID="btnDelete" class="button" runat="server" Text="Delete" OnClick="btnNew_Click" Visible="false" />
                    <br />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
                        BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px"
                        CellPadding="4" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="College Code">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Collegecode") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Collegecode") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Department Name">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Deptname") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Deptname") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Select Data">
                                <EditItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
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
                </div>
            </div>
        </div>
    </div>
</asp:Content>
