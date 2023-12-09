<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="WebApplication1.calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    body {
      font-family: Arial, sans-serif;
      display: flex;
      justify-content: center;
      align-items: center;
      height: 100vh;
      margin: 0;
      background-color: lightblue;
    }
    
    form {
      background-color: #fff;
      padding: 20px;
      border-radius: 8px;
      box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    }

    input {
      padding: 10px;
      margin: 5px;
      width: 200px;
      box-sizing: border-box;
      border: 1px solid #ccc;
      border-radius: 4px;
      outline: none;
    }
    .option{
        padding: 10px;
      margin: 5px;
      width: 200px;
      box-sizing: border-box;
      border: 1px solid #ccc;
      border-radius: 4px;
      outline: none;
    }
    .input-container
    {
        width= 100%;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="input-container">
            <center><h3>Calculator</h3></center>
            <label>Enter Number 1</label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            <label>Enter Number 2</label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br><br />
            <label>Select operation</label><br />
            <asp:DropDownList CssClass="option" ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Addition</asp:ListItem>
                <asp:ListItem>Multiplication</asp:ListItem>
                <asp:ListItem>Division</asp:ListItem>
                <asp:ListItem>Subtraction</asp:ListItem>
            </asp:DropDownList><br><br>
            <label>Result </label><br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br><br>
            
        </div>
    </form>
</body>
</html>
