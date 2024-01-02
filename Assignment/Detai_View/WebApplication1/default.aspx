<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Detail View</h1>
            <p>Enter Your Roll No. :
                <asp:TextBox ID="txtRoll" runat="server"></asp:TextBox></p>
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" /><br />
            <p>Enter Your Name :
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox></p>
            <p>Enter Your City :
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox></p>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" />
            <br />
            <asp:ListView ID="ListView1" runat="server" GroupPlaceholderID="GroupPlaceholder1" ItemPlaceholderID="ItemPlaceholder1" OnItemCommand="ListView1_ItemCommand">
                <LayoutTemplate>
                    <table border="1">
                        <tr>
                            <th>Roll no.</th>
                            <th>Student Name. </th>
                            <th>City.</th>
                            <th>Update</th>
                            <th>Delete</th>
                        </tr>
                        <asp:PlaceHolder runat="server" ID="GroupPlaceholder1"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <GroupTemplate>
                    <tr>
                        <asp:PlaceHolder runat="server" ID="ItemPlaceholder1"></asp:PlaceHolder>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td>
                        <asp:TextBox ID="txtLid" runat="server" Text='<%# Eval("Id") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLname" runat="server" Text='<%# Eval("Name") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLcity" runat="server" Text='<%# Eval("City") %>'></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" CommandName="update"></asp:Button>
                    </td>
                    <td>
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandName="delete"></asp:Button>
                    </td>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </form>
</body>
</html>
