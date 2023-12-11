<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Textscreen.aspx.cs" Inherits="WebApplication1.Textscreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .col {
            position: absolute;
        }

        .info {
            position: absolute;
            margin-left: 60%;
        }

        .imgclas {
            position: absolute;
            margin-left: 80%;
            width: 80%;
        }
        .upperd{
            width:100%;
            height:200px;
        }
        
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="upperd">
                <div class="col">
                    <h1>Online Exam Module<br />
                        <asp:Label ID="col_name" runat="server" Text="Label"></asp:Label>
                    </h1>
                </div>
                <div class="info">
                    Name :
                    <asp:Label ID="l_name" runat="server" Text="Label"></asp:Label><br />
                    Email :
                    <asp:Label ID="l_email" runat="server" Text="Label"></asp:Label><br>
                    Branch :
                    <asp:Label ID="l_branch" runat="server" Text="Label"></asp:Label><br>
                    Semester :
                    <asp:Label ID="l_sem" runat="server" Text="Label"></asp:Label><br>
                </div>
                <div class="imgclas">
                    <asp:Image ID="Image1" runat="server" Width="100px" Height="100px" />
                </div>
            </div>
            <div>
                <div class="allque">
                    <asp:MultiView ID="MultiView1" runat="server">
                        <asp:View ID="View1" runat="server">
                        </asp:View>
                        <asp:View ID="View2" runat="server">
                        </asp:View>
                        <asp:View ID="View3" runat="server">
                        </asp:View>
                        <asp:View ID="View4" runat="server">
                        </asp:View>
                        <asp:View ID="View5" runat="server">
                        </asp:View>
                        <asp:View ID="View6" runat="server">
                        </asp:View>
                        <asp:View ID="View7" runat="server">
                        </asp:View>
                        <asp:View ID="View8" runat="server">
                        </asp:View>
                        <asp:View ID="View9" runat="server">
                        </asp:View>
                        <asp:View ID="View10" runat="server">
                        </asp:View>
                    </asp:MultiView>
                </div>
                <div class="allbtn">
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                    <asp:Button ID="Button2" runat="server" Text="Button" />
                    <asp:Button ID="Button3" runat="server" Text="Button" />
                    <asp:Button ID="Button4" runat="server" Text="Button" />
                    <asp:Button ID="Button5" runat="server" Text="Button" />
                    <asp:Button ID="Button6" runat="server" Text="Button" />
                    <asp:Button ID="Button7" runat="server" Text="Button" />
                    <asp:Button ID="Button8" runat="server" Text="Button" />
                    <asp:Button ID="Button9" runat="server" Text="Button" />
                    <asp:Button ID="Button10" runat="server" Text="Button" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
