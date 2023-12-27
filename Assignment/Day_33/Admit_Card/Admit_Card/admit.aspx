<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admit.aspx.cs" Inherits="Admit_Card.admit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Card</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <link rel="stylesheet" type="text/css" href="Style1.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:FormView ID="FormView1" runat="server" Height="48px" Width="96px">
            <ItemTemplate>
                <section>
                    <div class="container">
                        <div class="admit-card">
                            <div class="BoxA border- padding mar-bot">
                                <div class="row">
                                    <div class="col-sm-4">
                                        <h5>RTMNU UNIVERSITY</h5>
                                        <p>Amravati Rd, Gokulpeth, Nagpur, Maharashtra 440033
                                            <br>
                                            Nagpur, INDIA</p>
                                    </div>
                                    <div class="col-sm-4 txt-center">
                                        <img src="https://res.cloudinary.com/sv-co/image/upload/v1654950642/LITE/Dashboard/Universities/RTMNU_Logo_qoo76a.png" style="height:100px; width:100px" />
                                    </div>
                                    <div class="col-sm-4">
                                        <h5>Admit Card</h5>
                                        <p>B.Tech - 2023</p>
                                    </div>
                                </div>
                            </div>
                            <div class="BoxC border- padding mar-bot">
                                <div class="row">
                                    <div class="col-sm-6">
                                        <h5>Enrollment No : <%# Eval("Enrollment") %></h5>
                                    </div>
                                </div>
                            </div>
                            <div class="BoxD border- padding mar-bot">
                                <div class="row">
                                    <div class="col-sm-10">
                                        <table class="table table-bordered">
                                            <tbody>
                                                <tr>
                                                    <td><b>Application NO : <%# Eval("Application") %></b></td>
                                                    <td><b>Course: </b>B.TECH</td>
                                                    <td><b>Date Of Exam : </b><%# Eval("DateExam") %></td>
                                                </tr>
                                                <tr>
                                                    <td><b>Student Name: </b><%# Eval("Name") %></td>
                                                    <td><b>Sex: </b><%# Eval("Gender") %></td>
                                                    <td><b>Time : </b><%# Eval("Etime") %></td>
                                                </tr>
                                                <tr>
                                                    <td><b>Cast : </b><%# Eval("NCast") %></td>
                                                    <td><b>DOB: </b><%# Eval("DOB") %></td>
                                                    <td><b>Exam Center Name : </b><%# Eval("Examcenter") %></td>
                                                </tr>
                                                <tr>
                                                    
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <div class="col-sm-2 txt-center">
                                        <table class="table table-bordered">
                                            <tbody>
                                                <tr>
                                                    <th scope="row txt-center">
                                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Photo", "~/img/{0}") %>' Width="123px" Height="165px"/></th>
                                                </tr>
                                                <tr>
                                                    <th scope="row txt-center">
                                                        <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("Signa", "~/sig/{0}") %>' Width="123px" Height="50px"/></th>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <div class="BoxE border- padding mar-bot txt-center">
                                <div class="row">
                                    <div class="col-sm-12">
                                        <h5>EXAMINATION VENUE</h5>
                                        <p><%# Eval("Examcenter") %> Katol Road Nagpur
                                            <br>
                                            Maharashtra, INDIA</p>
                                    </div>
                                </div>
                            </div>
                            
                            <footer class="txt-center">
                                <p>*** Best Of Luck ***</p>
                            </footer>

                        </div>
                    </div>

                </section>
            </ItemTemplate>
        </asp:FormView>

    </form>
</body>
</html>
