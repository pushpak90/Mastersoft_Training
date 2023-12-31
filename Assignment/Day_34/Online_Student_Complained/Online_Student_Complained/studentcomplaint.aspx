<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="studentcomplaint.aspx.cs" Inherits="Online_Student_Complained.studentcomplaint" %>

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
                        <asp:TextBox ID="txtCollegeName" runat="server" placeholder="Enter College Name" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtStudentName" runat="server" placeholder="Enter Student Name" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter Email" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtbranch" runat="server" placeholder="Enter Branch" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:DropDownList ID="ddlcomp" runat="server">
                            <asp:ListItem>Select Complaint</asp:ListItem>
                            <asp:ListItem>Account</asp:ListItem>
                            <asp:ListItem>Exam</asp:ListItem>
                            <asp:ListItem>SPORT</asp:ListItem>
                            <asp:ListItem>Admission</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtMessage" runat="server" placeholder="Enter Messgae"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtDate" runat="server" placeholder="Enter Date"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnSubmit" class="button" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <br />
                    <asp:Button ID="btnShow" class="button" runat="server" Text="Show" OnClick="btnShow_Click" />
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
                                    <asp:Label ID="lblcolname" runat="server" Text='<%# Eval("Collegename") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Student Name">
                                <ItemTemplate>
                                    <asp:Label ID="lblSname" runat="server" Text='<%# Eval("Sname") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Branch">
                                <ItemTemplate>
                                    <asp:Label ID="lblBranch" runat="server" Text='<%# Eval("Branch") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Complaint">
                                <ItemTemplate>
                                    <asp:Label ID="txtComplaint" runat="server" Text='<%# Eval("Complainto") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Message">
                                <ItemTemplate>
                                    <asp:Label ID="lblmsg" runat="server" Text='<%# Eval("msg") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Date">
                                <ItemTemplate>
                                    <asp:Label ID="lblDate" runat="server" Text='<%# Eval("C_date") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
