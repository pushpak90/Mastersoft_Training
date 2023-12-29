<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration_page.aspx.cs" Inherits="Admit_Card.registration_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
    <link rel="stylesheet" type="text/css" href="Style.css" />
    <link href="//fonts.googleapis.com/css?family=Roboto:300,300i,400,400i,700,700i" rel="stylesheet" />
</head>
<body>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <div class="container">
    <div class="content">
       <img src="https://res.cloudinary.com/debbsefe/image/upload/f_auto,c_fill,dpr_auto,e_grayscale/image_fz7n7w.webp" alt="header-image" class="cld-responsive">
            <h1 class="form-title">Register Here</h1>
            <form id="form1" runat="server">
            <div class="beside">
                <asp:TextBox ID="txtApplication" placeholder="Enter Application Number" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Application Number " ControlToValidate="txtApplication">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="txtEnrollment" placeholder="Enter Enrollment Number" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Enrollment Number" ControlToValidate="txtEnrollment">*</asp:RequiredFieldValidator>
            </div>
            <div class="beside">
                <asp:TextBox ID="txtName" placeholder="Enter Name" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Name" ControlToValidate="txtName">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="txtDob" placeholder="Enter DOB" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter DOB" ControlToValidate="txtDob">*</asp:RequiredFieldValidator>
            </div>
            <div class="beside">
                <asp:TextBox ID="txtCast" placeholder="Enter Cast" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Cast" ControlToValidate="txtCast">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="txtGender" placeholder="Enter Gender" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter Gender" ControlToValidate="txtGender">*</asp:RequiredFieldValidator>
            </div>
            <div class="beside">
                <asp:TextBox ID="txtDateofexam" placeholder="Enter Date Of Exam" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Enter Date Of Exam" ControlToValidate="txtDateofexam">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="txtTime" placeholder="Enter Time" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Enter Time" ControlToValidate="txtTime">*</asp:RequiredFieldValidator>
            </div>
            <div class="beside">
                <asp:TextBox ID="txtExamCenter" placeholder="Enter Exam Center Name" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Enter Exam Center Name" ControlToValidate="txtExamCenter">*</asp:RequiredFieldValidator>
            </div>
            <div class="beside">
                <asp:FileUpload ID="FileUpload1" runat="server" accept=".png,.jpg,.jpeg,.gif"/><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Enter Passport Photo" ControlToValidate="FileUpload1">*</asp:RequiredFieldValidator>
                <asp:FileUpload ID="FileUpload2" runat="server" accept=".png,.jpg,.jpeg,.gif"/><asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Enter Signature" ControlToValidate="FileUpload2">*</asp:RequiredFieldValidator>
            </div>
           <div class="beside">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="button" OnClick="btnSubmit_Click"/>
                <asp:Button ID="btnShow" runat="server" Text="Show" class="button" OnClick="btnShow_Click" CausesValidation="false"/>
            </div>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />*
                <div class="grid_view">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                    <Columns>
                        <asp:TemplateField HeaderText="Sr No.">
                        <ItemTemplate>
                            <%# Container.DataItemIndex+1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:BoundField DataField="Application" HeaderText="Application No" />
                        <asp:BoundField DataField="Enrollment" HeaderText="Enrollment No" />
                        <asp:BoundField DataField="Name" HeaderText="Student Name " />
                        <asp:BoundField DataField="DOB" HeaderText="DOB" />

                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <asp:Button ID="btnAdmit" runat="server" Text="Generate Admit Card" OnClick="brnAdmit_Click" CausesValidation="false"/>
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#33276A" />
                </asp:GridView>
                </div>
            </form>
        </div>
 </div>

</body>
</html>
