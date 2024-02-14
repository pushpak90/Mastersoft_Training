<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <%--<script src="JavaScript.js" type="text/javascript"></script>--%>
    <script src="jquery-3.7.1.min.js"></script>
    <script src="https://code.jquery.com/jquery-1.11.1.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <style>
        table {
            color: white;
        }

        /* Optional: Add styles for better visibility, such as background color */
        table, th, td {
            border: 1px solid black;
            border-collapse: collapse;
            padding: 10px;
        }

        /* Optional: Set background color for header cells */
        th {
            background-color: #333;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddlDeg" runat="server">
            <asp:ListItem Value="0">Please Select</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlbranch" runat="server">
            <asp:ListItem Value="0">Please Select</asp:ListItem>
        </asp:DropDownList>
        <div>
            <div id="container">
                <header>Register new account</header>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <fieldset>
                        <br />
                        <input type="text" name="username" id="txtName" placeholder="Username" />
                        <br />
                        <br />
                        <input type="text" name="email" id="txtEmail" placeholder="E-mail" />
                        <br />
                        <br />
                        <input type="text" name="password" id="txtCollege" placeholder="College" />
                        <br />
                        <br />
                        <input type="text" name="confirm-password" id="txtBranch" placeholder="Branch" />
                        <br />
                        <br />
                        <br />
                        <button type="button" id="btnSubmit">Submit</button>
                    </fieldset>
                </div>
            </div>
        </div>
        <table border="1">
            <!-- Table header row -->
            <thead id="tbhead">

            </thead>
            <!-- Table body rows -->
            <tbody id="tbody">
                
            </tbody>
        </table>
    </form>
    <script src="<%=Page.ResolveClientUrl("~/JavaScript.js")%>"></script>   
</body>
</html>
