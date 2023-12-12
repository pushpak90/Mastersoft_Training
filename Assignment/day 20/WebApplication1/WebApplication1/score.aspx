<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="score.aspx.cs" Inherits="WebApplication1.score" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
    * {
    padding: 0;

    box-sizing: border-box;
    font-family: 'Poppins', sans-serif;
}

body {
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 100vh;
    background: url(https://img.playbook.com/GkXdxuPUJybZqdTcLNt124xUnMD_bK19dxy4Z8SczhE/Z3M6Ly9wbGF5Ym9v/ay1hc3NldHMtcHVi/bGljLzJhNWYxODk1/LTE0ZWMtNGNjMi1h/ZGZlLTRkMzQxYWYw/Zjk1OQ);
    background-size: cover;
    background-position: center;
}

    .container {
      text-align: center;
      background-color: lightcoral;
      padding: 20px;
      border-radius: 8px;
      box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
      width : 600px;
      background: transparent;
    border: 2px solid rgba(255, 255, 255, .2);
    backdrop-filter: blur(20px);
    box-shadow: 0 0 10px rgba(0, 0, 0, .2);
    color: #fff;
    border-radius: 10px;
    padding: 30px 40px;
    }

    label {
      padding-bottom:20px;
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
            <div class="container">
         <asp:Image ID="Image1" runat="server" Height="130px" Width="104px" />
         <br />
         
    <h2>Marksheet </h2>
    <form id="markForm">
      <label for="name">
        <br />
        Name:</label><asp:Label ID="name" runat="server" Text="Label"></asp:Label><br />
      
        <label for="email">Email:</label><asp:Label ID="email" runat="server" Text="Label"></asp:Label><br>

      <label for="branch">Branch:</label><asp:Label ID="branch" runat="server" Text="Label"></asp:Label><br>

      <label for="sem">Semester:</label><asp:Label ID="sem" runat="server" Text="Label"></asp:Label><br>

      <label for="grade">Grade:</label><asp:Label ID="grade" runat="server" Text="Label"></asp:Label><label for="total">
      <br />
       Total Marks:</label></label><asp:Label ID="mark" runat="server" Text="Label"></asp:Label>

     
    </form>

    <div class="result" id="resultSection"></div>
  </div>

        </div>
    </form>
</body>
</html>
