<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam.aspx.cs" Inherits="WebApplication1.Exam" %>

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
            
        <div class="container">

            <h2><center>Login</center></h2>
        <p>
            Student N<label>ame :</label>
            <asp:Label ID="t_name" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <label>Student Email :</label>
            <asp:Label ID="t_email" runat="server" Text="Label"></asp:Label>
        </p>
            <p>
            <label>College Name :</label>
            <asp:TextBox ID="t_college" runat="server" class="tlable"></asp:TextBox>
        </p>
            <p>
            <label>Branch Name :</label>
            <asp:TextBox ID="t_branch" runat="server" class="tlable"></asp:TextBox>
        </p>
             <label>Semester :</label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
            </asp:DropDownList>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Start Test" OnClick="Button1_Click"  />
            </div>
        </div>
    </form>
</body>
</html>
