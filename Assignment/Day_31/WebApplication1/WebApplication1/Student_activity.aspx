<%@ Page Title="" Language="C#" MasterPageFile="~/Studentmaster.Master" AutoEventWireup="true" CodeBehind="Student_activity.aspx.cs" Inherits="WebApplication1.Student_activity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="form_wrapper">
        <div class="form_container">
            <div class="title_container">
                <h2>Student Activity Form</h2>
            </div>
            <div class="row clearfix">
                <div class="">
                   
                        <div class="row clearfix">
                            <div class="col_half">
                                <div class="input_field">
                                    <span><i aria-hidden="true" class="fa fa-user"></i></span>
                                    ID : <asp:Label ID="lblId" runat="server" style="left:40px" Text="Label"></asp:Label>
                                </div>
                            </div>
                            <div class="col_half">
                                <div class="input_field">
                                    <span><i aria-hidden="true" class="fa fa-user"></i></span>
                                    Name : <asp:Label ID="lblName" runat="server" style="left:40px" Text="Label"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            Dept. : <asp:Label ID="lblDept" runat="server" style="left:50px" Text="Label"></asp:Label>
                        </div>
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtAct" runat="server" placeholder="Enter Acivity" class="form-control" ></asp:TextBox>
                        </div> 
                        <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="txtDate" runat="server" placeholder="Enter Date of Activity" class="form-control" ></asp:TextBox>
                        </div> 

                    <div class="input_field">
    <span><i aria-hidden="true" class="fa fa-lock"></i></span>
    <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Org" class="form-control" ></asp:TextBox>
</div> 






                        
                    <div class="input_field">
                            <span><i aria-hidden="true" class="fa fa-lock"></i></span>
                            <asp:TextBox ID="TextBox1" runat="server" placeholder="Remark If Any" class="form-control" ></asp:TextBox>
                        </div> 
                        
                    <asp:Button ID="btnSubmit" class="button" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                   
                </div>
            </div>
        </div>
    </div>

</asp:Content>
