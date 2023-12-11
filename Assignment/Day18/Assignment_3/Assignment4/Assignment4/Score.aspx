<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Score.aspx.cs" Inherits="Assignment4.Score" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    body {
        background-color:lightpink
      font-family: Arial, sans-serif;
      display: flex;
      justify-content: center;
      align-items: center;
      height: 100vh;
      margin: 0;
      background-color: #f4f4f4;
    }

    .container {
      text-align: center;
      background-color: #fff;
      padding: 20px;
      border-radius: 8px;
      box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
      width : 400px;
    }

    label {
      display: block;
      margin: 10px 0;
    }

    label {
      padding: 8px;
      margin: 5px 0;
      width: 100%;
      box-sizing: border-box;
    }

    button {
      padding: 10px 20px;
      background-color: #4caf50;
      color: #fff;
      border: none;
      border-radius: 4px;
      cursor: pointer;
      margin-top: 10px;
    }

    .result {
      margin-top: 20px;
      border-top: 1px solid #ccc;
      padding-top: 10px;
    }
  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
       

         
     <div class="container">
         <asp:Image ID="Image1" runat="server" Height="130px" Width="104px" />
         <br />
         
    <h2>Marksheet </h2>
    <form id="markForm">
      <label for="name">
        <br />
        Name:</label><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
      
        <label for="email">Email:</label><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>

      <label for="branch">Branch:</label><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>

      <label for="sem">Semester:</label><asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>

      <label for="grade">Grade:<label for="total">Total Marks:</label></label><asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>

     
    </form>

    <div class="result" id="resultSection"></div>
  </div>
    </form>
</body>
</html>
