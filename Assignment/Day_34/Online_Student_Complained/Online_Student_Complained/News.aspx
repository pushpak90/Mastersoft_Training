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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Title" ControlToValidate="txtTitle">*</asp:RequiredFieldValidator>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtTitle" runat="server" placeholder="News Title"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Title" ControlToValidate="txtMessage">*</asp:RequiredFieldValidator>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtMessage" runat="server" placeholder="Enter Message"></asp:TextBox>
                    </div>
                    <div class="input_field">
                        <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                        <asp:TextBox ID="txtDate" runat="server" placeholder="Enter Date"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnLogin" class="button" runat="server" Text="Submit" OnClick="btnLogin_Click" />
                    <br />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    <asp:Button ID="btnNew" class="button" runat="server" Text="Show" OnClick="btnNew_Click" CausesValidation="false"/>
                    <br />
          </div>
            </div>
        </div>
    </div>
    <center style="position:absolute; top:850px; left:300px">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="True" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="White" />
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
                                    <asp:Button ID="btnupdate"  class="button" runat="server" Text="Edit" OnClick="btnupdate_Click" CausesValidation="false" />
                                </ItemTemplate>
                                <FooterTemplate>  
                                    <asp:Button ID="btnSubmit" class="button" runat="server"  Text="Submit" OnClick="btnSubmit_Click" CausesValidation="false"/>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" class="button" runat="server" Text="Delete" OnClick="btnDelete_Click" CausesValidation="false" />
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
