<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Online_Student_Complained._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Style.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <div>
                    <h1 style="color:#04AA6D"><center>Online Student Complained Handling System</center></h1>
                </div>
                <div class="img">
                    <img src="https://images.unsplash.com/photo-1562774053-701939374585?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8Y29sbGVnZXxlbnwwfHwwfHx8MA%3D%3D" style="width:600px; height:300px"/>
                </div>
                <div class="simg">
                    <img src="https://www.shutterstock.com/image-photo/portrait-cheerful-male-international-indian-260nw-2071252046.jpg" style="width:600px; height:300px"/>
                </div>
                <div class="btn1">
                    <asp:Button ID="btnCollege" runat="server" Text="College" ForeColor="#04AA6D" OnClick="btnCollege_Click"/>
                </div>
                <div class="btn2">
                    <asp:Button ID="btnStudent" runat="server" Text="Student" ForeColor="#04AA6D" OnClick="btnStudent_Click" />
                </div>
            </div>
        </div>
        <footer class="dfoo">Developed By - <i>Pushpak Fasate</i></footer>
    </form>
</body>
</html>
