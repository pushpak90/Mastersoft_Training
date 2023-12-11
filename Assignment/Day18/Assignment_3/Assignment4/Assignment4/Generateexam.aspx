<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generateexam.aspx.cs" Inherits="Assignment4.Generateexam" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title></title>
    </head>

    <body>
        <form id="form1" runat="server">
            <div>
                Name :
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
                Email :
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <br />
                Branch :
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                <br />
                Semester :
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                Question 1 : What is the implicit return typr of Constructor?<br />
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>No return type</asp:ListItem>
                    <asp:ListItem>A class object in which it is define</asp:ListItem>
                    <asp:ListItem>void</asp:ListItem>
                    <asp:ListItem>None</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <p>
                Question 2 : Which is the object created with new keyword?</p>
            <p>
                <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                    <asp:ListItem>At run time</asp:ListItem>
                    <asp:ListItem>At compile time</asp:ListItem>
                    <asp:ListItem>Depends on the code</asp:ListItem>
                    <asp:ListItem>None</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <p>
                Question 3 : Identify the incorrect constructor type.</p>
            <asp:RadioButtonList ID="RadioButtonList3" runat="server">
                <asp:ListItem>Friend Constructor</asp:ListItem>
                <asp:ListItem>Default Constructor</asp:ListItem>
                <asp:ListItem>Parameterized Constructor</asp:ListItem>
                <asp:ListItem>Copy Constructor</asp:ListItem>
            </asp:RadioButtonList>
            <p>
                Question 4 : Identify the scope resolution operator.</p>
            <asp:RadioButtonList ID="RadioButtonList4" runat="server">
                <asp:ListItem>:</asp:ListItem>
                <asp:ListItem>::</asp:ListItem>
                <asp:ListItem>?:</asp:ListItem>
                <asp:ListItem>None</asp:ListItem>
            </asp:RadioButtonList>
            <p>
                Question 5 : Choose the option below which is not a member of the class.</p>
            <asp:RadioButtonList ID="RadioButtonList5" runat="server">
                <asp:ListItem>Friend Function</asp:ListItem>
                <asp:ListItem>Static Function</asp:ListItem>
                <asp:ListItem>Virtual Function</asp:ListItem>
                <asp:ListItem>Const Function</asp:ListItem>
            </asp:RadioButtonList>
            <p>
                Question 6 : Total types of constructors in C++ are?</p>
            <p>
                <asp:RadioButtonList ID="RadioButtonList6" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <p>
                Question 7 : Which of the following is not a type of inheritance?</p>
            <p>
                <asp:RadioButtonList ID="RadioButtonList7" runat="server">
                    <asp:ListItem>Multiple</asp:ListItem>
                    <asp:ListItem>Multilevel</asp:ListItem>
                    <asp:ListItem>Distributed</asp:ListItem>
                    <asp:ListItem>Hierarchical</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <p>
                Question 8 : What is an object in C++?</p>
            <p>
                <asp:RadioButtonList ID="RadioButtonList8" runat="server">
                    <asp:ListItem>It is a function of class</asp:ListItem>
                    <asp:ListItem>It is an instance of the class</asp:ListItem>
                    <asp:ListItem>it is a the data type of class</asp:ListItem>
                    <asp:ListItem>it is part of the syntax of class</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <p>
                Question 9 : Identify the operators which cannot be overloaded.</p>
            <asp:RadioButtonList ID="RadioButtonList9" runat="server">
                <asp:ListItem>?:</asp:ListItem>
                <asp:ListItem>.(dot operator)</asp:ListItem>
                <asp:ListItem>&gt;&gt;</asp:ListItem>
                <asp:ListItem>Both A and B</asp:ListItem>
            </asp:RadioButtonList>
            <p>
                Question 10 : By default, fields in a structure of a C program is?</p>
            <asp:RadioButtonList ID="RadioButtonList10" runat="server">
                <asp:ListItem>Public</asp:ListItem>
                <asp:ListItem>Private</asp:ListItem>
                <asp:ListItem>Protected</asp:ListItem>
                <asp:ListItem>None</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </form>
    </body>

    </html>