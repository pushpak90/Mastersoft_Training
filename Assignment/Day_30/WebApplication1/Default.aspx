<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
</head>
<body class="bg-img">
    <div>
        <div class="registration-form">
            <form class="A1" id="form1" runat="server">
                <div class="A1"></div>
                <div class="registration-logo with-border">
                    <h1><b>Registration Form</b></h1>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtId" runat="server" class="form-control item" placeholder="Enter ID"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtName" runat="server" class="form-control item" placeholder="Enter Name"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-12">
                        <div>
                            <asp:TextBox runat="server" ID="txtEmail" placeholder="Enter Email" class="form-control item"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtMobile" runat="server" class="form-control item" placeholder="Enter Mobile"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtCollege" runat="server" class="form-control item" placeholder="Enter College"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtBranch" runat="server" class="form-control item" placeholder="Enter Branch"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtTotal" runat="server" class="form-control item" placeholder="Enter Total"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtPercentage" runat="server" class="form-control item" placeholder="Enter Percentage"></asp:TextBox>
                            <!-- <select class="countrypicker form-control item"></select> -->
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <asp:TextBox ID="txtGrade" runat="server" class="form-control item" placeholder="Enter Grade"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-block login-button" OnClick="btnSubmit_Click" />
                    </div>
                    <div class="col-md-6">
                        <asp:Button ID="btnShow" runat="server" Text="Show" class="btn btn-block login-button" OnClick="btnShow_Click" />
                    </div>
                </div>
                <div style="position: absolute; left: 150px; top: 600px; padding-bottom:100px">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" onRowDataBound="GridView1_RowDataBound" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="Sr No.">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Id" HeaderText="ID"></asp:BoundField>
                            <asp:BoundField DataField="Name" HeaderText="Name"></asp:BoundField>
                            <asp:BoundField DataField="Email" HeaderText="Email"></asp:BoundField>
                            <asp:BoundField DataField="Mobile" HeaderText="Mobile"></asp:BoundField>
                            <asp:TemplateField  HeaderText="Status">
                                <ItemTemplate >
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                        <asp:ListItem Value="Select">Please Select</asp:ListItem>
                                        <asp:ListItem Value="Approv">Approv</asp:ListItem>
                                        <asp:ListItem Value="Reject">Reject</asp:ListItem>
                                    </asp:DropDownList>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Total" HeaderText="Total" ></asp:BoundField>
                            <asp:BoundField DataField="Grade" HeaderText="Grade"></asp:BoundField>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btnUpdate" runat="server" Text="Update" onclick="btnUpdate_Click"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btnDelete" runat="server" Text="Delete" onclick="btnDelete_Click"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btnView" runat="server" Text="View" onclick="btnView_Click"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </div>
            </form>
        </div>

    </div>
</body>
</html>
