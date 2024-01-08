<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentReg.aspx.cs" Inherits="WebApplication1.StudentReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
    <style>
        .dd {
            position: absolute;
            left: 100px;
            margin-top: 100px
        }
    </style>
</head>
<body class="bg-img">
    <div>
        <div class="registration-form">
            <form class="A1" id="form1" runat="server">
                <div class="A1"></div>
                <div class="registration-logo with-border">
                    <h1><b>Student Information Form</b></h1>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtName" runat="server" class="form-control item" placeholder="Enter Name"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="form-group">
                            <!--<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>-->
                            <asp:TextBox ID="txtdate" runat="server" TextMode="Date" class="form-control item"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <div>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:DropDownList ID="ddlDegree" runat="server" class="form-control item" OnSelectedIndexChanged="ddlDegree_SelectedIndexChanged" AutoPostBack="true">
                                <asp:ListItem>Select Degree</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:DropDownList ID="ddlBranch" runat="server" class="form-control item">
                                <asp:ListItem>Select Branch</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtEmail" runat="server" class="form-control item" placeholder="Enter Email"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtMobile" runat="server" class="form-control item" placeholder="Enter Mobile"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">

                            <asp:FileUpload ID="FileUpload1" runat="server" class="form-control item" accept=".jpg, .jpeg, .png" />
                            <!-- <select class="countrypicker form-control item"></select> -->

                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Select Statuc"></asp:Label><asp:CheckBox ID="CheckBox1" runat="server" />
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-4">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-block login-button" OnClick="btnSubmit_Click" />
                    </div>
                    <div class="col-md-4">
                        <asp:Button ID="btnReport" runat="server" Text="Report" class="btn btn-block login-button" />
                    </div>
                    <div class="col-md-4">
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="btn btn-block login-button" OnClick="btnCancel_Click" />
                    </div>
                </div>
                <div class="dd">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="528px" Width="1144px" BackColor="White" BorderColor="White" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" CellSpacing="1" GridLines="None">
                        <Columns>
                            <asp:TemplateField HeaderText="Sr. No">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Edit">
                                <ItemTemplate>
                                    <asp:Button ID="btnUpdate" runat="server" class="btn btn-block login-button" Text="Update" OnClientClick="return confirm ('Do you want to Update')" OnClick="btnUpdate_Click"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Delete">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" runat="server" class="btn btn-block login-button" OnClientClick="return confirm ('Do you want to Delete')" Text="Delete" OnClick="btnDelete_Click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Name">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtGName" runat="server" Text='<%# Eval("Name") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Date Of Birth">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtGdob" runat="server" Text='<%# Eval("DOB") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Gender">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtGgender" runat="server" Text='<%# Eval("Gender") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Degree">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtGDegree" runat="server" Text='<%# Eval("Degree") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Branch">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtGBranch" runat="server" Text='<%# Eval("Branch") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Photo" ItemStyle-Height="200px" ControlStyle-Width="200px">
                                <ItemTemplate>
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "/upload/" + Eval("Photo") %>' Width="100px" Height="100px" />
                                    <asp:FileUpload ID="FileUpload2" runat="server" accept=".jpg, .jpeg, .png"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Status">
                                <ItemTemplate>
                                    <asp:Label ID="txtGstatus" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#594B9C" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#33276A" />
                    </asp:GridView>
                </div>
            </form>
        </div>

    </div>
</body>

</html>
