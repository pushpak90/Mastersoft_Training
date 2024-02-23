<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Todo list</title>
    <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:ScriptManager runat="server" EnablePageMethods="true"></asp:ScriptManager>
            <input type="text" id="txtExample" name="txtExample" placeholder="Type you todo here here..."/>
             <input type="button" id="btnAdd" value="ADD" />
        </div>

        <script src="JavaScript.js"></script>
    </form>
</body>
</html>
