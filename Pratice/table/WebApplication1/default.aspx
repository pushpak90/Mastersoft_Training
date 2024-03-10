<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bulk Data</title>
   <script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Text Input -->
            <label for="username">First Name :</label>
            <input type="text" id="txtFirstName" name="username" placeholder="Enter First Name"/>

            <br />

            <label for="username">Last Name :</label>
            <input type="text" id="txtLastName" name="username" placeholder="Enter Last Name"/>

            <br />
            
            <!-- Submit Button -->
            <input type="button" id="btnSubmit" value="Submit" />
            <input type="button" id="btnSubmitTable" value="Submit Table" />
        </div>
        <div>
            <div id="table">

            </div>
        </div>
    </form>
    <script src="<%=Page.ResolveClientUrl("~/JavaScript.js")%>"></script> 
</body>
</html>
