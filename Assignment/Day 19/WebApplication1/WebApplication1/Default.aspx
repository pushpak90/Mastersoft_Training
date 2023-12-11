<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

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
      h2 {
      color: #333;
      }
      .tlabel {
      display: block;
      margin: 10px 0;
      color: #555;
      }
       button{
           padding: 10px 20px;
      background-color: #4caf50;
      color: #fff;
      border: none;
      border-radius: 4px;
      cursor: pointer;
      margin-top: 10px;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <h2><center>Registration Form</center></h2>
        <p>
            <label>Enter Name :</label>
            <asp:TextBox ID="t_name" runat="server" class="tlable"></asp:TextBox>
        </p>
        <p>
            <label>Enter Email ID :</label>
            <asp:TextBox ID="t_email" runat="server" class="tlable"></asp:TextBox>
        </p>
        <p>
            <label>Enter Password :</label>
            <asp:TextBox ID="t_password" runat="server" class="tlable"></asp:TextBox>
        </p>
        <p>
            <label>Enter Mobile :</label>
            <asp:TextBox ID="t_mobile" runat="server" class="tlable"></asp:TextBox>
        </p>
        <p>
            <label>Upload Photo :</label>
            <asp:FileUpload ID="img" runat="server" accept=".png,.jpg,.jpeg,.gif"/>
        </p>
        <p>
            <label>Date of Registration :</label>
            <asp:TextBox ID="T_date" runat="server" class="tlable"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Btn_login"  runat="server" Text="Login Button" OnClick="Btn_login_Click" />
        </p>
            </div>
       
    </form>
</body>
</html>
