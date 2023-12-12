<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
      font-family: Arial, sans-serif;
      background-color: lightblue;
      margin: 0;
      display: flex;
      justify-content: center;
      align-items: center;
      height: 100vh;
      }
      .container {
      background-color:lightcoral;
      padding: 20px;
      border-radius: 8px;
      box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
      width: 400px;
      text-align: center;
      border-style: solid;
      }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        

        <div class="container">

            <h2><center>Login</center></h2>
        <p>
            <label>Enter Email :</label>
            <asp:TextBox ID="t_email" runat="server" class="tlable"></asp:TextBox>
        </p>
        <p>
            <label>Enter Password:</label>
            <asp:TextBox ID="t_password" runat="server" class="tlable"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            </div>
    </form>
</body>
</html>
