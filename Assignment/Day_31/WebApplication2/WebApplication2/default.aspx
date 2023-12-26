<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
</head>
<body>
        <div>
        <div class="registration-form">
            <form class="A1" id="form2" runat="server">
                <div class="A1"></div>
                <div class="registration-logo with-border">
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <div class="form-group">
                            <asp:TextBox ID="txtRoll" runat="server" class="form-control item" placeholder="Enter ID"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-4">
                        <div class="form-group">
                            <asp:TextBox ID="txtName" runat="server" class="form-control item" placeholder="Enter Name"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-4">
						<div class="form-group">
							
                            <asp:DropDownList ID="ddlCity" runat="server" class="form-control " placeholder="Select City">
                                <asp:ListItem>SelectCity</asp:ListItem>
                                <asp:ListItem>Nagpur</asp:ListItem>
                                <asp:ListItem>Pune</asp:ListItem>
                                <asp:ListItem>Mumbai</asp:ListItem>
                            </asp:DropDownList>
						</div>
					</div>
                </div>
                <div class="row">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Width="315px">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:TemplateField HeaderText="Student Detail">
                            <ItemTemplate>
                                <b>Roll</b>
                                <asp:Label ID="lblRoll" runat="server" Text='<%# Eval("Roll") %>'></asp:Label>
                                <br />
                                <b>Name</b>
                                <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                                <br />
                                <b>City</b>
                                <asp:Label ID="lblCity" runat="server" Text='<%# Eval("City") %>'></asp:Label>
                                <br />
                                <hr />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>
                <br />

                </div>
                <div class="row">
                    <div class="col-md-4">
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-block login-button" OnClick="btnUpdate_Click"   />
                    </div>
                    <div class="col-md-4">
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-block login-button" OnClick="btnDelete_Click"   />
                    </div>
                    <div class="col-md-4">
                        <asp:Button ID="btnInsert" runat="server" Text="Insert" class="btn btn-block login-button" OnClick="btnInsert_Click"   />
                    </div>
                </div>
            </form>
        </div>

    </div>
</body>
</html>
