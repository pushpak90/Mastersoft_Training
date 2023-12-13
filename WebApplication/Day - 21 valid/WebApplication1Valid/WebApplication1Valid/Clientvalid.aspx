<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientvalid.aspx.cs" Inherits="WebApplication1Valid.Clientvalid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="JavaScript" type="text/javascript">
        function validationCheck()
        {
            var summary = "";
            summary += isValidUser();   //function cascating
            summary += isValidFname();
            summary += isValidLname();
            if (summary != "")
            {
                alert(summary);
                return false;
            }
            else
            {
                return true;
            }
        }
        function isValidUser()
        {
            var id;
            var temp = document.getElementById(<%=txtUsername.ClientID%>);
            id = temp.value;
            if (id == "") {
                return ("Please enter user name");
            }
            else
            {
                return "";
            }
        }
        function isValidFname()
        {
            var id;
            var temp = document.getElementById(<% =txtFname.ClientID %>);
            id = temp.value;
            if (id == "") {
                return ("Please enter First name");
            }
            else
            {
                return "";
            }
        }
        function isValidLname()
        {
            var id;
            var temp = document.getElementById(<%=txtLname.ClientID%>);
            id = temp.value;
            if (id == "") {
                return ("Please enter First name");
            }
            else
            {
                return "";
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Client Side Validation</h1>
        </div>
        <p>
            Regisration Form :
        </p>
        <p>
            Uername -
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </p>
        <p>
            First Name -
            <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
        </p>
        <p>
            Last Name -
            <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </form>
</body>
</html>
