<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="finial.aspx.cs" Inherits="WebApplication1.finial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet2.css" />
    <link rel="shortcut icon" href="favicon.ico">
    <link href='https://fonts.googleapis.com/css?family=Roboto:400,500,400italic,300italic,300,500italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="wrapper">
        <div class="sidebar-wrapper">
            <div class="profile-container"> <asp:Image class="profile-img" ID="Image1" runat="server" />
                <h1 class="name">
                    <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label></h1>
                <h3 class="tagline">Web Developer</h3> </div>
            <!--//profile-container-->
            <div class="contact-container container-block">
                <ul class="list-unstyled contact-list">
                    <li class="email"><i class="fa fa-envelope"></i><a href="shindesharad71@gmail.com">
                        <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label></a></li>
                    <li class="phone"><i class="fa fa-phone"></i><a href="tel:07038555441">
                        <asp:Label ID="lblMobile" runat="server" Text="Label"></asp:Label></a></li>
                    <li class="phone"><i class="fa fa-phone"></i><a href="tel:07038555441">
                        <asp:Label ID="lblCity" runat="server" Text="Label"></asp:Label></a></li>
                    <li class="phone"><i class="fa fa-phone"></i><a href="tel:07038555441">
                        <asp:Label ID="lblpin" runat="server" Text="Label"></asp:Label></a></li>
                    <li class="phone"><i class="fa fa-phone"></i><a href="tel:07038555441">
                        <asp:Label ID="lblAddress" runat="server" Text="Label"></asp:Label></a></li>
                </ul>
            </div>
            <!--//contact-container-->
            <div class="education-container container-block">
                <h2 class="container-block-title">Education</h2>
                <div class="item">
                    <h4 class="degree">
                        <asp:Label ID="lblUgname" runat="server" Text="Label"></asp:Label></h4>
                    <h5 class="meta">University of Pune</h5>
                    
                </div>
                <!--//item-->
                <div class="item">
                    <h4 class="degree">
                        <asp:Label ID="lblPgname" runat="server" Text="Label"></asp:Label></h4>
                    <h5 class="meta">
                        <asp:Label ID="lblYop" runat="server" Text="Label"></asp:Label></h5>
                    <div class="time">2012 - 2015</div>
                </div>
                <!--//item-->
            </div>
            <!--//education-container-->
            <div class="languages-container container-block">
                <h2 class="container-block-title">Languages</h2>
                <ul class="list-unstyled interests-list">
                    <li>Marathi <span class="lang-desc">(Native)</span></li>
                    <li>English <span class="lang-desc">(Professional)</span></li>
                    <li>Hindi <span class="lang-desc">(Professional)</span></li>
                </ul>
            </div>
        </div>
        <!--//sidebar-wrapper-->
        <div class="main-wrapper">
            <section class="section summary-section">
                <h2 class="section-title"><i class="fa fa-user"></i>Career Profile</h2>
                <div class="summary">
                    <p>
                        <asp:Label ID="lblObj" runat="server" Text="Label"></asp:Label></p>
                </div>
                <!--//summary-->
            </section>
            <!--//section-->
            <section class="skills-section section">
                <h2 class="section-title"><i class="fa fa-rocket"></i>Skills &amp; Proficiency</h2>
                <div class="skillset">
                    <div class="item">
                        <h3 class="level-title">HTML5 &amp; CSS</h3>
                        <div class="level-bar">
                            <div class="level-bar-inner" data-level="85%"> </div>
                        </div>
                        <!--//level-bar-->
                    </div>
                    <!--//item-->
                    <div class="item">
                        <h3 class="level-title">Bootstrap</h3>
                        <div class="level-bar">
                            <div class="level-bar-inner" data-level="70%"> </div>
                        </div>
                        <!--//level-bar-->
                    </div>
                    <!--//item-->
                    <div class="item">
                        <h3 class="level-title">Javascript &amp; jQuery</h3>
                        <div class="level-bar">
                            <div class="level-bar-inner" data-level="68%"> </div>
                        </div>
                        <!--//level-bar-->
                    </div>
                    <!--//item-->
                    <div class="item">
                        <h3 class="level-title">PHP &amp; MySQL</h3>
                        <div class="level-bar">
                            <div class="level-bar-inner" data-level="76%"> </div>
                        </div>
                        <!--//level-bar-->
                    </div>
                    <!--//item-->
                    <div class="item">
                        <h3 class="level-title">Angular</h3>
                        <div class="level-bar">
                            <div class="level-bar-inner" data-level="48%"> </div>
                        </div>
                        <!--//level-bar-->
                    </div>
                    <!--//item-->
                </div>
            </section>
            <!--//skills-section-->
            <section class="section experiences-section">
                <h2 class="section-title"><i class="fa fa-briefcase"></i>Experiences</h2>
                <div class="item">
                    <div class="meta">
                        <div class="upper-row">
                            <h3 class="job-title">
                                <asp:Label ID="lblComp" runat="server" Text="Label"></asp:Label></h3>
                            <div class="time">
                                <asp:Label ID="lblYear" runat="server" Text="Label"></asp:Label></div>
                        </div>
                        <!--//upper-row-->
                        <div class="company">Date Of Joining : <asp:Label ID="lblJdate" runat="server" Text="Label"></asp:Label></div>
                    </div>
                    <!--//meta-->
                    <div class="details">
                        <p>Other Experence : <asp:Label ID="lblOther" runat="server" Text="Label"></asp:Label></p>
                    </div>
                    <!--//details-->
                </div>
                <!--//item-->
            </section>
            <!--//section-->
            <section class="section projects-section">
                <h2 class="section-title"><i class="fa fa-archive"></i>Projects</h2>
                <div class="intro">
                    <p>I made some open source projects. Here are my some best projects.</p>
                </div>
                <!--//intro-->
                <div class="item"> <span class="project-title"><a href="http://club-zero.in" target="_blank">Club ZERO</a></span> - <span class="project-tagline">A elite group of Developers, Designers and Managers.</span></div>
                <!--//item-->
                <div class="item"> <span class="project-title"><a href="https://github.com/shindesharad71/Club-Manager" target="_blank">Club Manager</a></span> - <span class="project-tagline">A Social Club/Group Organizer with Blogging Platform Made Using PHP.</span> </div>
                <!--//item-->
                <div class="item"> <span class="project-title"><a href="https://github.com/shindesharad71/DigiWord" target="_blank">DigiWord</a></span> - <span class="project-tagline">A Single Author Blogging Platform Created with PHP & Bootstrap.</span> </div>
                <!--//item-->
                <div class="item"> <span class="project-title"><a href="https://github.com/shindesharad71/account-registration-verification-in-php" target="_blank">Account Manager</a></span> - <span class="project-tagline">A simple php user registration and email verification module.</span> </div>
                <!--//item-->
            </section>
            <!--//section-->
        </div>
        <!--//main-body-->
    </div>
    <footer class="footer">
        <div class="text-center">
            <small class="copyright"><a href="http://sharadshinde.in" target="_blank">Sharad Shinde</a> 2016</small>
        </div>
    </footer>
        </div>
    </form>
</body>
</html>
