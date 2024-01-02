<%@ Page Title="" Language="C#" MasterPageFile="~/Collegeadmin.Master" AutoEventWireup="true" CodeBehind="departmentuser.aspx.cs" Inherits="Online_Student_Complained.departmentuser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form_wrapper">
        <div class="form_container">
            <div class="title_container">
                <h2>College Login</h2>
            </div>
            <div class="row clearfix">
                <div class="">
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        College Name :
                        <asp:TextBox ID="txtname" runat="server" placeholder="Enter College" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        College Code :
                        <asp:TextBox ID="txtcode" runat="server" placeholder="Enter College" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        Department Name :
                        <asp:DropDownList ID="ddlDept" runat="server" OnSelectedIndexChanged="Page_Load"></asp:DropDownList>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Faculty Name" ControlToValidate="txtFaculty">*</asp:RequiredFieldValidator>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtFaculty" runat="server" placeholder="Enter Name/Faculty Name"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter User ID" ControlToValidate="txtUser">*</asp:RequiredFieldValidator>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtUser" runat="server" placeholder="Enter User ID"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Password" ControlToValidate="txtpass">*</asp:RequiredFieldValidator>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtpass" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtDate" runat="server" placeholder="Enter Date"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnLogin" class="button" runat="server" Text="Submit" OnClick="btnLogin_Click1" />
                    <br />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    <asp:Button ID="btnNew" class="button" runat="server" Text="Show" OnClick="btnNew_Click" CausesValidation="false"/>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Select Department Name : " Visible="false"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" Visible="false"></asp:DropDownList>
                    <asp:Button ID="btnFind" runat="server" Text="Find" Visible="false" OnClick="btnFind_Click" CausesValidation="false"/>
                </div>
            </div>
        </div>
    </div>
     <center style="position:absolute; top:1000px; left: 200px">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="100px" Width="500px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" >
                        <Columns>
                            <asp:TemplateField HeaderText="Sr No.">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="College Name">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtcolname" runat="server" Text='<%# Eval("Collegecode") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Department">
                                <ItemTemplate>
                                    <asp:Label ID="lblDept" runat="server" Text='<%# Eval("Deptname") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Faculty Name">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtFname" runat="server" Text='<%# Eval("Username") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="User Id">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtId" runat="server" Text='<%# Eval("UserId") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Password">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtpass" runat="server" Text='<%# Eval("Userpass") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" CausesValidation="false"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CausesValidation="false"/>
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
         </center>
</asp:Content>
