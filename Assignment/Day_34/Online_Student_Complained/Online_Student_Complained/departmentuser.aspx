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
                        <asp:DropDownList ID="ddlDept" runat="server"></asp:DropDownList>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtFaculty" runat="server" placeholder="Enter Name/Faculty Name"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtUser" runat="server" placeholder="Enter User ID"></asp:TextBox>
                    </div>
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
                    <asp:Button ID="btnNew" class="button" runat="server" Text="Show" OnClick="btnNew_Click" />
                    <br />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:TemplateField HeaderText="Sr No.">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="College Name">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtcolname" runat="server" Text='<%# Eval("Collegename") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Department">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtDept" runat="server" Text='<%# Eval("Deptname") %>'></asp:TextBox>
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
                                    <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#<%= GridView1.ClientID%>').prepend($("<thead></thead>").append($("#<%=GridView1.ClientID%>").find("tr:first"))).DataTable({ stateSave: true, });
        });
    </script>
</asp:Content>
