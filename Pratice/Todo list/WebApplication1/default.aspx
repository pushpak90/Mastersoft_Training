<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Todo list</title>
    <script>
        var baseUrl = '<%= ResolveClientUrl("~/") %>';
    </script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text" id="tname" name="fname" />
            <input type="button" id="btnSave" value="Save" />
            <br/>Todo list<br />
            <label id="todomsg"></label>
        </div>
    </form>

    <script src="<%=Page.ResolveClientUrl("~/JavaScript.js")%>"></script>

</body>
</html>
