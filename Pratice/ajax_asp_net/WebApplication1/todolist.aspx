<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="todolist.aspx.cs" Inherits="WebApplication1.todolist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <%--<script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>--%>
    <script src="https://code.jquery.com/jquery-1.11.1.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text" id="fname" name="fname" />
            <input type="button" id="btnSave" value="Save"/>
        </div>
    </form>
    <script src="<%=Page.ResolveClientUrl("~/JavaScript1.js")%>"></script> 
</body>
</html>
