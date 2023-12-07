<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Home Page</h1>
        </div>
    <p>
        Page Navigation Concept</p>
    <p>
        1. link button control</p>
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" PostBackUrl="~/about.aspx">Visit About Us Page</asp:LinkButton>
        </p>
        <p>
            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/contact.aspx">Visit Contact Us Page</asp:LinkButton>
        </p>
        <p>
            Link button using attribute</p>
        <asp:LinkButton ID="LinkButton3" runat="server" Text="Contact Page" postbackUrl="~/contact.aspx"></asp:LinkButton>
        <br />
        <br />
        2.Hyper Link Control -<asp:HyperLink ID="HyperLink2" runat="server">HyperLink</asp:HyperLink>
&nbsp;<p class="MsoNormal">
            Generally use to navigate website<o:p> </o:p>
        </p>
        <p class="MsoNormal">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.abc.com">Visit My Website</asp:HyperLink>
        </p>
        <p class="MsoNormal">
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="http://www.abc.com" Text="Thank You"></asp:HyperLink>
        </p>
        <p class="MsoNormal">
            &nbsp;</p>
        <p class="MsoNormal">
            3. Navigation useing code
        </p>
        <p class="MsoNormal">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Visit About Us" />
        </p>
        <p class="MsoNormal">
            4. Navigation using transfer
        </p>
        <p class="MsoNormal">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Contact Us Page" />
        </p>
        <p class="MsoNormal">
            &nbsp;</p>
        <p class="MsoNormal">
            Date Time Implimentation</p>
        <p class="MsoNormal">
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="date time display" />
        </p>
        <p class="MsoNormal">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p class="MsoNormal">
            &nbsp;</p>
    </form>
    </body>
</html>
