<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam.aspx.cs" Inherits="WebApplication1.Exam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link type="text/css" rel="stylesheet" href="Style.css" /> 
    <script language="JavaScript" type="text/javascript">
        function choice()
        {
            var x = document.getElementById("<%=DropDownList1.ClientID%>").value;
            if (x == "Select") {
                alert("Provide Semester");
                return false;
            }
        }
    </script>
</head>
<body>
    
        <div class="wrapper">
            <form id="form1" runat="server">
        <div>
            
            <h2><center>Login</center></h2>
        <p>
            <label class="labelcls">Student Name :</label>
            <asp:Label ID="t_name" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <label class="labelcls">Student Email :</label>
            <asp:Label ID="t_email" runat="server" Text="Label"></asp:Label>
        </p>
            <p>
         
            <asp:TextBox ID="txtCollege" placeholder="Enter College"  runat="server" class="tlable"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter College Name*" ControlToValidate="txtCollege"></asp:RequiredFieldValidator>
        </p>
            <p>
           
            <asp:TextBox ID="txtBranch" placeholder="Enter Branch" runat="server" class="tlable"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Branch Name*" ControlToValidate="txtBranch"></asp:RequiredFieldValidator>
        </p>
             <label class="labelcls">Semester :</label>
            <asp:DropDownList ID="DropDownList1" class="btn" runat="server">
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
            <asp:Button ID="Button1" class="btn" runat="server" Text="Start Test" OnClick="Button1_Click"  />
            </div>
                </form>
            </div>
        
    
</body>
</html>
