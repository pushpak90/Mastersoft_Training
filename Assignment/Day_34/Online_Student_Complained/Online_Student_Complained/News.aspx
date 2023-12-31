<%@ Page Title="" Language="C#" MasterPageFile="~/Collegeadmin.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Online_Student_Complained.News" %>
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
                        <asp:TextBox ID="txtname" runat="server" placeholder="Enter College Name" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        College Code :
                        <asp:TextBox ID="txtcode" runat="server" placeholder="Enter College Code" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtTitle" runat="server" placeholder="News Title"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtMessage" runat="server" placeholder="Enter Message"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtDate" runat="server" placeholder="Enter Message"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnLogin" class="button" runat="server" Text="Submit" OnClick="btnLogin_Click" />
                    <br />
                    <asp:Button ID="btnNew" class="button" runat="server" Text="Show" OnClick="btnNew_Click"  />
                    <br />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="true">
                        <Columns>
                            <asp:TemplateField HeaderText="Sr No.">
                                 <ItemTemplate>
                                    <%# Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="College Code">
                                 <ItemTemplate>
                                     <asp:TextBox ID="txtColcode" runat="server"  Text='<%# Eval("Collegecode") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Name">
                                 <ItemTemplate>
                                     <asp:TextBox ID="txtColname" runat="server" Text='<%# Eval("Collegename") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Title">
                                 <ItemTemplate>
                                     <asp:TextBox ID="txtTitle" runat="server" Text='<%# Eval("Newstitle") %>'></asp:TextBox>
                                </ItemTemplate>
                                <FooterTemplate>  
                                    <asp:TextBox ID="txtTitle" runat="server" ></asp:TextBox>  
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Message">
                                 <ItemTemplate>
                                     <asp:TextBox ID="txtMessage" runat="server" Text='<%# Eval("n_Message") %>'></asp:TextBox>
                                </ItemTemplate>
                                <FooterTemplate>  
                                    <asp:TextBox ID="txtMessage" runat="server" ></asp:TextBox>  
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btnupdate" runat="server" Text="Edit" OnClick="btnupdate_Click" />
                                </ItemTemplate>
                                <FooterTemplate>  
                                    <asp:Button ID="btnSubmit" class="button" runat="server"  Text="Submit" OnClick="btnSubmit_Click"/>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" class="button" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
          </div>
            </div>
        </div>
    </div>
</asp:Content>
