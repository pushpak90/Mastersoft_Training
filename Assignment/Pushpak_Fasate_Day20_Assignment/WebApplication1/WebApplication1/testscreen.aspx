<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testscreen.aspx.cs" Inherits="WebApplication1.testscreen" %>

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
            background-color: lightgreen;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            background: url(https://img.playbook.com/GkXdxuPUJybZqdTcLNt124xUnMD_bK19dxy4Z8SczhE/Z3M6Ly9wbGF5Ym9v/ay1hc3NldHMtcHVi/bGljLzJhNWYxODk1/LTE0ZWMtNGNjMi1h/ZGZlLTRkMzQxYWYw/Zjk1OQ);
            background-size: cover;
            background-position: center;
        }

        .col {
            height: 150px;
            position: absolute;
            left: 10px;
            width: 62%;
            top: 10px;
            color: white;
            background: transparent;
            backdrop-filter: blur(20px);
            box-shadow: 0 0 10px rgba(0, 0, 0, .2);
            color: #fff;
            border-radius: 10px;
        }

            .col h1 {
                margin-left: 20%;
            }

        .info {
            position: absolute;
            margin-left: 62%;
            left: 44px;
            top: 15px;
            color: white;
            background: transparent;
            backdrop-filter: blur(20px);
            box-shadow: 0 0 10px rgba(0, 0, 0, .2);
            color: #fff;
            border-radius: 10px;
            width: 20%;
            height: 150px;
        }

            .info label {
                margin-left: 20%;
            }

        .imgclas {
            position: absolute;
            margin-left: 80%;
            width: 80%;
            background: transparent;
            backdrop-filter: blur(20px);
            box-shadow: 0 0 10px rgba(0, 0, 0, .2);
            color: #fff;
            border-radius: 10px;
            width: 20%;
            height: 150px;
        }

        }

        .upperd {
            width: 100%;
            height: 200px;
        }

        .allque {
            position: absolute;
            top: 200px;
            left: 13px;
            width: 700px;
            height: 400px;
            background: transparent;
            backdrop-filter: blur(20px);
            box-shadow: 0 0 10px rgba(0, 0, 0, .2);
            color: #fff;
            border-radius: 10px;
            width: 75%;
            height: 300px;
        }

        .allbtn {
            position: absolute;
            left: 80%;
            top: 250px;
            color: white;
            background: transparent;
            backdrop-filter: blur(20px);
            box-shadow: 0 0 10px rgba(0, 0, 0, .2);
            color: #fff;
            border-radius: 10px;
            height: 250px;
        }

        #que1 {
            margin: 10px;
        }

        #que2 {
            margin: 10px;
        }

        #que3 {
            margin: 10px;
        }

        #que4 {
            margin: 10px;
        }

        #que5 {
            margin: 10px;
        }

        #que6 {
            margin: 10px;
        }

        #que7 {
            margin: 10px;
        }

        #que8 {
            margin: 10px;
        }

        #que9 {
            margin: 10px;
        }

        #que10 {
            margin: 10px;
        }

        #Score {
            position: absolute;
            top: 500px;
            left: 500px
        }

        #Score {
            width: 20%;
            height: 45px;
            border-radius: 40px;
            border: none;
            outline: none;
            box-shadow: 0 0 10px rgba(0, 0, 0, .1);
            cursor: pointer;
            font-size: 16px;
            color: #333;
            font-weight: 600;
            top: 550px;
            position: absolute;
            border: 2px solid rgba(255, 255, 255, .2);
        }

        }

        <script language="JavaScript" type="text/javascript" >
        function choice() {
        var x = document.getElementById("<%=RadioButtonList1.ClientID%>").value;
        if(x == "")
        {
            alert("Provide Semester");
            return false;
        }

        }
        </script >
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <div class="upperd">
                <div class="col">
                    <h1>Online Exam Module<br />
                        <asp:Label ID="col_name" runat="server" Text="Label"></asp:Label>
                    </h1>
                </div>
                <div class="info">

                    <label style="top: 10px">
                        <br />
                        Name :</label>
                    <asp:Label ID="l_name" runat="server" Text="Label"></asp:Label><br />
                    <label>Email :</label>
                    <asp:Label ID="l_email" runat="server" Text="Label"></asp:Label><br>
                    <label>Branch :</label>
                    <asp:Label ID="l_branch" runat="server" Text="Label"></asp:Label><br>
                    <label>Semester :</label>
                    <asp:Label ID="l_sem" runat="server" Text="Label"></asp:Label><br>
                </div>
                <asp:Image CssClass="image" Style="position: absolute; left: 89%; top: 28px; height: 134px;" ID="Image1" runat="server" Width="117px" />
            </div>
            <div>
                <div class="allque">
                    <asp:MultiView ID="MultiView1" runat="server">
                        <asp:View ID="View1" runat="server">
                            Question 1 : What is the implicit return typr of Constructor?<br />
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                                <asp:ListItem>No return type</asp:ListItem>
                                <asp:ListItem>A class object in which it is define</asp:ListItem>
                                <asp:ListItem>void</asp:ListItem>
                                <asp:ListItem>None</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View2" runat="server">
                            Question 2 : Which is the object created with new keyword?
                           <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True">
                               <asp:ListItem>At run time</asp:ListItem>
                               <asp:ListItem>At compile time</asp:ListItem>
                               <asp:ListItem>Depends on the code</asp:ListItem>
                               <asp:ListItem>None</asp:ListItem>
                           </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View3" runat="server">
                            Question 3 : Identify the incorrect constructor type.
                            <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="True">
                                <asp:ListItem>Friend Constructor</asp:ListItem>
                                <asp:ListItem>Default Constructor</asp:ListItem>
                                <asp:ListItem>Parameterized Constructor</asp:ListItem>
                                <asp:ListItem>Copy Constructor</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View4" runat="server">
                            Question 4 : Identify the scope resolution operator.
                            <asp:RadioButtonList ID="RadioButtonList4" runat="server" AutoPostBack="True">
                                <asp:ListItem>:</asp:ListItem>
                                <asp:ListItem>::</asp:ListItem>
                                <asp:ListItem>?:</asp:ListItem>
                                <asp:ListItem>None</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View5" runat="server">
                            Question 5 : Choose the option below which is not a member of the class.
                            <asp:RadioButtonList ID="RadioButtonList5" runat="server" AutoPostBack="True">
                                <asp:ListItem>Friend Function</asp:ListItem>
                                <asp:ListItem>Static Function</asp:ListItem>
                                <asp:ListItem>Virtual Function</asp:ListItem>
                                <asp:ListItem>Const Function</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View6" runat="server">
                            Question 6 : Total types of constructors in C++ are?
                            <asp:RadioButtonList ID="RadioButtonList6" runat="server" AutoPostBack="True">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View7" runat="server">
                            Question 7 : Which of the following is not a type of inheritance?
                            <asp:RadioButtonList ID="RadioButtonList7" runat="server" AutoPostBack="True">
                                <asp:ListItem>Multiple</asp:ListItem>
                                <asp:ListItem>Multilevel</asp:ListItem>
                                <asp:ListItem>Distributed</asp:ListItem>
                                <asp:ListItem>Hierarchical</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View8" runat="server">
                            Question 8 : What is an object in C++?
                            <asp:RadioButtonList ID="RadioButtonList8" runat="server" AutoPostBack="True">
                                <asp:ListItem>It is a function of class</asp:ListItem>
                                <asp:ListItem>It is an instance of the class</asp:ListItem>
                                <asp:ListItem>it is a the data type of class</asp:ListItem>
                                <asp:ListItem>it is part of the syntax of class</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View9" runat="server">
                            Question 9 : Identify the operators which cannot be overloaded.
                            <asp:RadioButtonList ID="RadioButtonList9" runat="server" AutoPostBack="True">
                                <asp:ListItem>?:</asp:ListItem>
                                <asp:ListItem>.(dot operator)</asp:ListItem>
                                <asp:ListItem>&gt;&gt;</asp:ListItem>
                                <asp:ListItem>Both A and B</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:View>
                        <asp:View ID="View10" runat="server">
                            Question 10 : By default, fields in a structure of a C program is?
                            <asp:RadioButtonList ID="RadioButtonList10" runat="server" AutoPostBack="True">
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
                    <asp:Button ID="que2" runat="server" Text="2" OnClick="Button2_Click" Height="30px" Width="30px" />
                    <asp:Button ID="que3" runat="server" Text="3" OnClick="que3_Click" Height="30px" Width="30px" /><br />
                    <asp:Button ID="que4" runat="server" Text="4" OnClick="que4_Click" Height="30px" Width="30px" />
                    <asp:Button ID="que5" runat="server" Text="5" OnClick="que5_Click" Height="30px" Width="30px" />
                    <asp:Button ID="que6" runat="server" Text="6" OnClick="que6_Click" Height="30px" Width="30px" /><br />
                    <asp:Button ID="que7" runat="server" Text="7" OnClick="que7_Click" Height="30px" Width="30px" />
                    <asp:Button ID="que8" runat="server" Text="8" OnClick="que8_Click" Height="30px" Width="30px" />
                    <asp:Button ID="que9" runat="server" Text="9" OnClick="que9_Click" Height="30px" Width="30px" /><br />
                    <asp:Button ID="que10" runat="server" Text="10" OnClick="que10_Click" Height="30px" Width="30px" />
                </div>
            </div>
        </div>
        <div>
            <asp:Button ID="Score" Class="btn" runat="server" Text="Button" OnClick="Score_Click" />
        </div>
    </form>
</body>
</html>
