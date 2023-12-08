<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="m_view.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Registration Form</h1>
        </div>
            
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <center>Student Details</center>
                <br /><br />
                Name :
                <asp:TextBox ID="textname" runat="server"></asp:TextBox>
                <br /><br/>
                City :
                <asp:TextBox ID="textcity" runat="server"></asp:TextBox>
                <br /><br/>
                College :
                <asp:TextBox ID="textcollege" runat="server"></asp:TextBox>
                <br /><br/>
                Email :
                <asp:TextBox ID="textemail" runat="server"></asp:TextBox>
                <br /><br/>
                Mobile :
                <asp:TextBox ID="textmobile" runat="server"></asp:TextBox>
                <br /><br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Next" /><br />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <center>Qualification Details</center>
                Name :
                <asp:Label ID="label_name" runat="server" Text="Label"></asp:Label>
                <br /><br />
                College Name :
                <asp:Label ID="label_college" runat="server" Text="Label"></asp:Label>
                <br /><br />
                Branch :
                <asp:TextBox ID="textbranch" runat="server"></asp:TextBox>
                <br /><br />
                Semester :
                <asp:TextBox ID="textsem" runat="server"></asp:TextBox>
                <br /><br />
                Subject : 
                <asp:TextBox ID="textsub" runat="server"></asp:TextBox>
                <br /><br />
                <asp:Button ID="Button2" runat="server" Text="Next" OnClick="Button2_Click" />
            </asp:View>
            <asp:View ID="View3" runat="server">
                <center>Mark Allotment</center>
                Student Name : 
                <asp:Label ID="label_name_3" runat="server" Text="Label"></asp:Label>
                <br /><br />
                College Name : 
                <asp:Label ID="label_college_name_3" runat="server" Text="Label"></asp:Label>
                <br /><br />
                Branch Name : 
                <asp:Label ID="label_branch_3" runat="server" Text="Label"></asp:Label>
                <br /><br />
                Mark 1: 
                <asp:TextBox ID="mark1" runat="server"></asp:TextBox><br /><br />
                Mark 2:
                <asp:TextBox ID="mark2" runat="server"></asp:TextBox><br /><br />
                Mark 3:
                <asp:TextBox ID="mark3" runat="server"></asp:TextBox><br /><br />
                Mark 4:
                <asp:TextBox ID="mark4" runat="server"></asp:TextBox><br /><br />
                Mark 5:
                <asp:TextBox ID="mark5" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" Text="Next" OnClick="Button3_Click" />
                <br /><br />
            </asp:View>
            <asp:View ID="View4" runat="server">
                <center>Mark Report</center>
                Student Name :
                <asp:Label ID="label4_name" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                Email :<asp:Label ID="label4_email" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                Mobile :<asp:Label ID="label4_mobile" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                Branch :<asp:Label ID="label4_branch" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                Subject :<asp:Label ID="label4_subject" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                Total :<asp:Label ID="label4_total" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                Grade :<asp:Label ID="label4_grade" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Finish" />
            </asp:View>
            <asp:View ID="View5" runat="server">
                
                Dear Student,
                <asp:Label ID="label5_name" runat="server" Text="Label"></asp:Label>
                <br />
                
                <br />
                City :<asp:Label ID="label5_city" runat="server" Text="Label"></asp:Label>
                <br />
                College :<asp:Label ID="label5_college" runat="server" Text="Label"></asp:Label>
                <br />
                Email :<asp:Label ID="label5_email" runat="server" Text="Label"></asp:Label>
                <br />
                Mobile :<asp:Label ID="label5_mobile" runat="server" Text="Label"></asp:Label>
                <br />
                Branch :<asp:Label ID="label5_branch" runat="server" Text="Label"></asp:Label>
                <br />
                Semester :<asp:Label ID="label5_sem" runat="server" Text="Label"></asp:Label>
                <br />
                Subject :<asp:Label ID="label5_sub" runat="server" Text="Label"></asp:Label>
                <br />
                Mark1 :<asp:Label ID="label5_m1" runat="server" Text="Label"></asp:Label>
                <br />
                Mark 2 :<asp:Label ID="label5_m2" runat="server" Text="Label"></asp:Label>
                <br />
                Mark 3 :<asp:Label ID="label5_m3" runat="server" Text="Label"></asp:Label>
                <br />
                Mark 4 :<asp:Label ID="label5_m4" runat="server" Text="Label"></asp:Label>
                <br />
                Mark 5 :<asp:Label ID="label5_m5" runat="server" Text="Label"></asp:Label>
                <br />
                Total :
                <asp:Label ID="label5_total" runat="server" Text="Label"></asp:Label>
                <br />
                Grade :
                <asp:Label ID="label5_grade" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                Thank You To Register.
            </asp:View>
        </asp:MultiView>
    </form>
</body>
</html>
