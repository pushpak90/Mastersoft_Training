<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Style.css" />
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
                            <asp:TextBox ID="txtId" runat="server" class="form-control item" placeholder="Enter ID"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-4">
                        <div class="form-group">
                            <asp:TextBox ID="txtCollege" runat="server" class="form-control item" placeholder="Enter College"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <asp:TextBox ID="txtDept" runat="server" class="form-control item" placeholder="Enter Dept"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row">

                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="ID" />
                            <asp:BoundField DataField="College" HeaderText="College Name" />
                            
                            <asp:TemplateField HeaderText="Dept">
                                <ItemTemplate>
                                    <asp:Repeater ID="Repeater1" runat="server">
                                        <ItemTemplate>
                                            <asp:Label ID="lblDept" runat="server" Text='<%# Eval("Dept") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                        </Columns>
                    </asp:GridView>

                </div>
                <br />
                <div class="row">
                    <div class="col-md-6">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-block login-button" OnClick="btnSubmit_Click" />
                    </div>
                    <div class="col-md-6">
                        <asp:Button ID="btnShow" runat="server" Text="Show" class="btn btn-block login-button" OnClick="btnShow_Click" />
                    </div>
                </div>
            </form>
        </div>

    </div>
</body>
</html>
