<%@ Page Title="" Language="C#" MasterPageFile="~/Studentmaster.Master" AutoEventWireup="true" CodeBehind="view_hostory.aspx.cs" Inherits="WebApplication1.view_hostory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form_wrapper">
        <div class="form_container">
            <div class="title_container">
                <h2>Mark Details Form</h2>
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
                            Mark Alloted : <asp:Label ID="Label1" runat="server" style="left:100px" Text="Label"></asp:Label>
                        </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
