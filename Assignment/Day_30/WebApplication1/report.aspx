<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="WebApplication1.report_aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="bg"></div>
        <div class="card">

            <div class="top">
                <p class="category">Nature</p>
            </div>

            <div class="bottom">
                <h2></h2>
                <div class="author">
                    <div class="profile"></div>
                </div>
                    <div class="intro">
                        Id :<asp:Label ID="lblId" runat="server" Text="Label"></asp:Label>
                        <br />
                        Name:<asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
                        <br />
                        Email:<asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
                        <br />
                        Mobile:<asp:Label ID="lblMobile" runat="server" Text="Label"></asp:Label>
                        <br />
                        Status:<asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label>
                        <br />
                        Grade:<asp:Label ID="lblGrade" runat="server" Text="Label"></asp:Label>
                        <br />
                        Percentage:<asp:Label ID="lblPercentage" runat="server" Text="Label"></asp:Label>
                        <br />
                        Total:<asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
                        <br />
                    </div>
            </div>
        </div>
    </form>
</body>
</html>
