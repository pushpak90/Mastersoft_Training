<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Textscreen.aspx.cs" Inherits="WebApplication1.Textscreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .col {
            position: absolute;
            left: 200px
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
        .allque{
            position:absolute;
            left: 200px;

        }
        .allbtn{
            position : absolute;
            margin-left : 60%;
            top : 150px
        }
        #que1{
            margin:10px;
        }
        #que2{
            margin:10px;
        }
        #que3{
            margin:10px;
        }
        #que4{
            margin:10px;
        }
        #que5{
            margin:10px;
        }
        #que6{
            margin:10px;
        }
        #que7{
            margin:10px;
        }
        #que8{
            margin:10px;
        }
        #que9{
            margin:10px;
        }
        #que10{
            margin:10px;
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
                            Question 1 : What is the implicit return typr of Constructor?<br />
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                               <asp:ListItem>No return type</asp:ListItem>
                               <asp:ListItem>A class object in which it is define</asp:ListItem>
                               <asp:ListItem>void</asp:ListItem>
                               <asp:ListItem>None</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View2" runat="server">
                            Question 2 : Which is the object created with new keyword?
                           <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                               <asp:ListItem>At run time</asp:ListItem>
                               <asp:ListItem>At compile time</asp:ListItem>
                               <asp:ListItem>Depends on the code</asp:ListItem>
                               <asp:ListItem>None</asp:ListItem>
                           </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View3" runat="server">
                             Question 3 : Identify the incorrect constructor type.
                            <asp:RadioButtonList ID="RadioButtonList3" runat="server">
                                <asp:ListItem>Friend Constructor</asp:ListItem>
                                <asp:ListItem>Default Constructor</asp:ListItem>
                                <asp:ListItem>Parameterized Constructor</asp:ListItem>
                                <asp:ListItem>Copy Constructor</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View4" runat="server">
                            Question 4 : Identify the scope resolution operator.
                            <asp:RadioButtonList ID="RadioButtonList4" runat="server">
                                <asp:ListItem>:</asp:ListItem>
                                <asp:ListItem>::</asp:ListItem>
                                <asp:ListItem>?:</asp:ListItem>
                                <asp:ListItem>None</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View5" runat="server">
                            Question 5 : Choose the option below which is not a member of the class.
                            <asp:RadioButtonList ID="RadioButtonList5" runat="server">
                                <asp:ListItem>Friend Function</asp:ListItem>
                                <asp:ListItem>Static Function</asp:ListItem>
                                <asp:ListItem>Virtual Function</asp:ListItem>
                                <asp:ListItem>Const Function</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View6" runat="server">
                            Question 6 : Total types of constructors in C++ are?
                            <asp:RadioButtonList ID="RadioButtonList6" runat="server">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View7" runat="server">
                            Question 7 : Which of the following is not a type of inheritance?
                            <asp:RadioButtonList ID="RadioButtonList7" runat="server">
                                <asp:ListItem>Multiple</asp:ListItem>
                                <asp:ListItem>Multilevel</asp:ListItem>
                                <asp:ListItem>Distributed</asp:ListItem>
                                <asp:ListItem>Hierarchical</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View8" runat="server">
                            Question 8 : What is an object in C++?
                            <asp:RadioButtonList ID="RadioButtonList8" runat="server">
                                <asp:ListItem>It is a function of class</asp:ListItem>
                                <asp:ListItem>It is an instance of the class</asp:ListItem>
                                <asp:ListItem>it is a the data type of class</asp:ListItem>
                                <asp:ListItem>it is part of the syntax of class</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View9" runat="server">
                             Question 9 : Identify the operators which cannot be overloaded.
                            <asp:RadioButtonList ID="RadioButtonList9" runat="server">
                                <asp:ListItem>?:</asp:ListItem>
                                <asp:ListItem>.(dot operator)</asp:ListItem>
                                <asp:ListItem>&gt;&gt;</asp:ListItem>
                                <asp:ListItem>Both A and B</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View10" runat="server">
                            Question 10 : By default, fields in a structure of a C program is?
                            <asp:RadioButtonList ID="RadioButtonList10" runat="server">
                                <asp:ListItem>Public</asp:ListItem>
                                <asp:ListItem>Private</asp:ListItem>
                                <asp:ListItem>Protected</asp:ListItem>
                                <asp:ListItem>None</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                    </asp:MultiView>
                </div>
                <div class="allbtn">
                    <asp:Button ID="que1" runat="server" Text="1" OnClick="Button1_Click" Height="30px" Width="30px" />
                    <asp:Button ID="que2" runat="server" Text="2" OnClick="Button2_Click" Height="30px" width="30px"/>
                    <asp:Button ID="que3" runat="server" Text="3" OnClick="que3_Click" Height="30px" width="30px"/><br />
                    <asp:Button ID="que4" runat="server" Text="4" OnClick="que4_Click" Height="30px" width="30px"/>
                    <asp:Button ID="que5" runat="server" Text="5" OnClick="que5_Click" Height="30px" width="30px"/>
                    <asp:Button ID="que6" runat="server" Text="6" OnClick="que6_Click" Height="30px" width="30px"/><br />
                    <asp:Button ID="que7" runat="server" Text="7" OnClick="que7_Click" Height="30px" width="30px"/>
                    <asp:Button ID="que8" runat="server" Text="8" OnClick="que8_Click" Height="30px" width="30px"/>
                    <asp:Button ID="que9" runat="server" Text="9" OnClick="que9_Click" Height="30px" width="30px"/><br />
                    <asp:Button ID="que10" runat="server" Text="10" OnClick="que10_Click" Height="30px" width="30px"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
