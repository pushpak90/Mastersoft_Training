<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Message.aspx.cs" Inherits="WebApplication1.Message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
body {
    font-family: 'Roboto', sans-serif;
    margin: 0;
    padding: 0;
  background-image: url("https://cdn.pixabay.com/photo/2019/12/01/18/43/fog-4666170_1280.jpg");
    background-repeat: no-repeat;
    background-size: cover;
}

.chat-container {
    width: 400px;
    margin: 50px auto;
    background-color: #f5f5f5;
    border-radius: 5px;
    box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
}

.chat-header {
    background-color: #3f51b5;
    color: #fff;
    padding: 10px;
    text-align: center;
    border-top-left-radius: 5px;
    border-top-right-radius: 5px;
}

.chat-log {
    padding: 10px;
    max-height: 300px;
    overflow-y: auto;
}

.chat-message {
    margin-bottom: 10px;
    padding: 5px 10px;
    border-radius: 5px;
}

.bot {
    background-color: #eee;
}

.user {
    background-color: #3f51b5;
    color: #fff;
    float: right;
}

.chat-input {
    display: flex;
    align-items: center;
    background-color: #fff;
    padding: 5px;
    border-top: 1px solid #ccc;
    border-bottom: 1px Solid #3f51b5;
}

.chat-input input {
    flex: 1;
    border: none;
    padding: 8px;
    font-size: 14px;
    border-radius: 5px;
    margin-right: 5px;
}

.chat-input button {
    border: none;
    background-color: transparent;
    color: #3f51b5;
    cursor: pointer;
}

.chat-input button:hover {
    color: #2c387e;
}

/* Previous CSS styles */

/* Your other styles here */

.footer {
    position: fixed;
    bottom: 0;
    left: 0;
    width: 100%;
    padding: 10px;
    text-align: center;
}

.social-contact {
    position: fixed;
    right: 20px;
    bottom: 20px;
}

.social-link {
    display: inline-block;
    background-color: #3f51b5;
    color: #fff;
    border-radius: 50%;
    width: 40px;
    height: 40px;
    line-height: 40px;
    text-align: center;
    margin: 5px;
    font-size: 18px;
    transition: background-color 0.3s ease;
}

.social-link:hover {
    background-color: #2c387e;
}
</style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="chat-container">
        <div class="chat-header">
            <h2><i class="fas fa-robot animated"></i> Thank You For Registration</h2>
        </div>
        <div class="chat-log" id="chatLog">
            <div class="chat-message bot">
                <p>Thank You,
                    <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label></p>
                <p>Roll No :
                    <asp:Label ID="lblRoll" runat="server" Text="Label"></asp:Label>
                </p>
                <p>Email :
                    <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
                </p>
                <p>Mobile :
                    <asp:Label ID="lblMobile" runat="server" Text="Label"></asp:Label>
                </p>
                <p>City :
                    <asp:Label ID="lblCity" runat="server" Text="Label"></asp:Label>
                </p>
                <p>Subject :
                    <asp:Label ID="lblSubject" runat="server" Text="Label"></asp:Label>
                </p>
                <p>Total :
                    <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
                </p>
                <p>Grade : 
                    <asp:Label ID="lblGrade" runat="server" Text="Label"></asp:Label>
                </p>
            </div>
        </div>
        
    </div>
        </div>
    </form>
</body>
</html>
