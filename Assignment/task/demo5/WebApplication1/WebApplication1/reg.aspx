<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="WebApplication1.reg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script type="text/javascript">

        function previewImage() {
            var input = document.getElementById('FileUpload1');
            var img = document.getElementById('DBImage1');

            if (input.files && input.files[0]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    img.src = e.target.result;
                };

                reader.readAsDataURL(input.files[0]);
            }
        }

        function valnum() {

            if (document.getElementById("<%= txtName.ClientID %>").value == "") {
                alert("Provide Name");
            }
            

            // Validate Email
            var email = $("#<%= txtemail.ClientID %>").val();
            if (document.getElementById("<%= txtemail.ClientID %>").value == "") {
                alert("Email cannot be empty. Script");
            }
            var emailRegex = "/^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/";

          

            // Validate Mobile
            var mobile = $("#<%= txtphone.ClientID %>").val();
            if (mobile.trim() === "") {
                alert("Mobile cannot be empty.");
                return false;
            }
            var mobileRegex = /^\+[1-9]{3}[0-9]{9}$/; //  /^\+[1-9]{3}[0-9]{9}$/    /^[6-9]\d{9}$/
            if (!mobileRegex.test(mobile)) {
                alert("Invalid Mobile format. Please enter a 10-digit number starting with 6-9.");
                return false;
            }

            if (document.getElementById("<%= txtDOB.ClientID %>").value == "") {
                alert("Provide DOB");
            }

            // Validate Dept Dropdown
            var value = document.getElementById("<%= ddlDept.ClientID%>");
            var gettext = value.options[value.selectedIndex].text;
            if (gettext == "Select Degree") {
                alert("Plz select value in drop down");
            }


            // Validate Gender Dropdown
            var gender = $("#<%=radGender.ClientID%> input:checked").val();
            if (!gender) {
                alert("Please select a Gender.");
                return false;
            }

             if (document.getElementById("<%= FileUpload1.ClientID %>").value == "") {
                alert("Provide Photo");
            }

        }

        /*
        // Validate Email Format
            var emailRegex = /^\w+([-+.']\w+)@\w+([-.]\w+)\.\w+([-.]\w+)*$/;
            if (!emailRegex.test(email)) {
                alert("Invalid Email format. Please enter a valid email address.");
                return false;
            }
            */
    </script>

    <style type="text/css">
        .listd {
            position: absolute;
            left: -350px;
        }
        #imagePreview {
            max-width: 300px;
            max-height: 300px;
        }
    </style>

    <div class="card-body">
        <div role="form" class="text-start" style="width: 400px; left: 650px; top: 200px; position: absolute; top: 50px">
            <div class="input-group input-group-outline my-3">
                <asp:TextBox ID="txtName" runat="server" class="form-control" placeholder="Enter Name" ToolTip="Provide Name"></asp:TextBox>
            </div>
            <div class="input-group input-group-outline mb-3">

                <asp:TextBox ID="txtemail" runat="server" class="form-control" placeholder="Enter Email" ToolTip="Provide Email"></asp:TextBox>

            </div>
            <!--
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Email" ControlToValidate="txtemail"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter Correct Email" ControlToValidate="txtemail" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"></asp:RegularExpressionValidator>
            -->
            <div class="input-group input-group-outline mb-3">
                <asp:TextBox ID="txtphone" runat="server" class="form-control" placeholder="Enter Phone" ToolTip="Provide Number"></asp:TextBox>
            </div>
            <!--
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Phone" ControlToValidate="txtphone"></asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter Correct Phone with country code" ControlToValidate="txtphone" ValidationExpression="^\+[1-9]{3}[0-9]{9}$"></asp:RegularExpressionValidator>
                -->
            <div class="input-group input-group-outline mb-3">
                <asp:TextBox ID="txtDOB" runat="server" class="form-control" placeholder="Enter DOB" TextMode="Date" ToolTip="Enter Date Of Birth"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="Label2" runat="server" Text="Select Degree" class="form-control"></asp:Label>
                <asp:DropDownList ID="ddlDept" runat="server" Width="100%">
                </asp:DropDownList>
            </div>

            <div>
                <asp:Label ID="Label1" runat="server" Text="Select Gender" class="form-control"></asp:Label>
                <asp:RadioButtonList ID="radGender" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div class="input-group input-group-outline mb-3">
                <asp:FileUpload ID="FileUpload1" runat="server" class="form-control" accept=".png, .jpg, .jpeg" onchange="previewImage()"/>
            </div>

            <div class="input-group input-group-outline mb-3">
                <asp:Image ID="DBImage1" runat="server" Height="100px" Width="100px" ClientIDMode="Static"/>
            </div>

            <div class="text-center">

                <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn bg-gradient-primary w-100 my-4 mb-2" OnClick="btnSubmit_Click" OnClientClick="valnum()" />

            </div>

            <div class="listd">
                <asp:ListView ID="ListView1" runat="server" GroupPlaceholderID="GroupPlaceholder1" ItemPlaceholderID="ItemPlaceholder1" OnItemCommand="ListView1_ItemCommand">
                    <LayoutTemplate>
                        <table> 
                            <tr>
                                <th>NAME</th>
                                <th>Email</th>
                                <th>Phone No</th>
                                <th>Image</th>
                                <th>Action</th>
                            </tr>
                            <asp:PlaceHolder ID="GroupPlaceholder1" runat="server"></asp:PlaceHolder>
                        </table>

                    </LayoutTemplate>

                    <GroupTemplate>
                        <tr>
                            <asp:PlaceHolder ID="ItemPlaceholder1" runat="server"></asp:PlaceHolder>
                        </tr>

                    </GroupTemplate>

                    <ItemTemplate>

                        <td>
                            <asp:Label ID="lblLid" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                        </td>

                        <td>
                            <asp:Label ID="lblLname" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                        </td>
                        <td>


                            <asp:Label ID="lblLemail" runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="txtLphone" runat="server" Text='<%#Eval("Phone") %>'></asp:Label>

                        </td>
                        <td>
                            <!--
                            <asp:TextBox ID="txtLpic" runat="server" Text='<%#Eval("Pic") %>'></asp:TextBox>
                            -->
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "/upload/" + Eval("Pic") %>' Height="100px" Width="100px" />
                        </td>

                        <td>

                            <asp:Button ID="btnupdate1" runat="server" Text="UPDTAE" CommandName="updatelist" />
                        </td>

                    </ItemTemplate>
                </asp:ListView>
            </div>

        </div>
    </div>
</asp:Content>
