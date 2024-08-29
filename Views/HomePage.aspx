<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ProjectSE.Views.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/HomePageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="banner">
            <div class="container">
                <h1>We Help People,
                    <br />
                    To Help People.</h1>
                <asp:Button CssClass="joinbtn" ID="ButtonJoin" runat="server" Text="Start Helping" OnClick="ButtonJoin_Click" />
            </div>
        </div>

        <div class="ourfocus">
            <div class="head">
                <h1>Our Focus</h1>
            </div>
            <div class="ourfocus-container">
                <div class="nature">
                    <h2>NATURE</h2>
                </div>
                <div class="people">
                    <h2>PEOPLE</h2>
                </div>
                <div class="education">
                    <h2>EDUCATION</h2>
                </div>
            </div>
        </div>

        <div class="why">
            <div class="container">
                <div class="leftcontent">
                    <h1>Why <span class="wait">Wait?</span>
                        <br />
                        Start make an
                        <br />
                        <span class="impact">Impact!</span></h1>
                </div>
                <div class="rightcontent">
                    <div class="volun">
                        <div class="top">
                            <img class="image" src="../Assets/Two Fingers.png" alt="Alternate Text" />
                            <h2>Volunteer</h2>
                        </div>
                        <p>Apapun bantuanmu berarti besar bagi mereka.</p>
                        <asp:Button ID="ButtonVolunteer" CssClass="buttonVolunteer" runat="server" Text="Join Volunteer" OnClick="ButtonVolunteer_Click"/>
                    </div>

                    <div class="donate">
                        <div class="top">
                            <img class="image" src="../Assets/Hand Holding Heart.png" alt="Alternate Text" />
                            <h2>Donate</h2>
                        </div>
                        <p>Berapapun donasimu berarti besar bagi mereka.</p>
                        <asp:Button ID="ButtonDonate" CssClass="buttonDonate" runat="server" Text="Start Giving" OnClick="ButtonDonate_Click"/>
                    </div>
                </div>
            </div>
        </div>

        <div class="blog">
            <div class="blog-container">
                <img class="image" src="../Assets/blog_art 1.png" alt="Alternate Text" />
                <div class="blog-text">
                    <div class="insidetext">
                        <h1>Explore Our Blog</h1>
                        <p>Sebuah platform yang berbasis di Indonesia  yang memfasilitasi kesempatan relawan bagi  individu yang ingin berkontribusi dalam  kegiatan sosial dan berbagai proyek nirlaba.  Melalui situs web, Climates menyediakan  berbagai informasi tentang proyek-proyek  relawan, acara, dan kegiatan sosial yang  berlangsung di berbagai daerah di Indonesia. Sebuah platform yang berbasis di Indonesia  yang memfasilitasi kesempatan relawan bagi  individu yang ingin berkontribusi dalam  kegiatan sosial dan berbagai proyek nirlaba.  Melalui situs web, Climates menyediakan  berbagai informasi tentang proyek-proyek  relawan, acara, dan kegiatan sosial yang  berlangsung di berbagai daerah di Indonesia.</p>
                        <p>Sebuah platform yang berbasis di Indonesia  yang memfasilitasi kesempatan relawan bagi  individu yang ingin berkontribusi dalam  kegiatan sosial dan berbagai proyek nirlaba.  Melalui situs web, Climates menyediakan  berbagai informasi tentang proyek-proyek  relawan, acara, dan kegiatan sosial yang  berlangsung di berbagai daerah di Indonesia. Sebuah platform yang berbasis di Indonesia  yang memfasilitasi kesempatan relawan bagi  individu yang ingin berkontribusi dalam  kegiatan sosial dan berbagai proyek nirlaba.  Melalui situs web, Climates menyediakan  berbagai informasi tentang proyek-proyek  relawan, acara, dan kegiatan sosial yang  berlangsung di berbagai daerah di Indonesia.</p>
                    </div>

                    <asp:Button ID="ButtonExplore" CssClass="buttonExplore" runat="server" Text="Explore More" OnClick="ButtonExplore_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
