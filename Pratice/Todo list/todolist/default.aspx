<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="todolist._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>User Details</h2>
            <label for="name">Name:</label>
            <input type="text" id="txtName" />

            <label for="email">Email:</label>
            <input type="text" id="txtEmail" />

           <input type="button" id="savedata" value="Submit" />

            <script src="<%=Page.ResolveClientUrl("~/JavaScript.js")%>"></script> 

        </div>
    </form>
</body>
</html>
