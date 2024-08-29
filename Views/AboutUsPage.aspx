<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="AboutUsPage.aspx.cs" Inherits="ProjectSE.Views.AboutUsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/AboutUsPageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="banner">
            <div class="container">
                <h1>About Climates</h1>
            </div>
        </div>

        <div class="aboutclimates">
            <div class="container">
                <h1>Apa itu CLIMATES?</h1>
                <p>Sebuah platform yang berbasis di Indonesia yang memfasilitasi kesempatan relawan bagi individu yang ingin berkontribusi dalam kegiatan sosial dan berbagai proyek nirlaba. Melalui situs web, Climates menyediakan berbagai informasi tentang proyek-proyek relawan, acara, dan kegiatan sosial yang berlangsung di berbagai daerah di Indonesia.</p>
            </div>
        </div>

        <div class="sdg">
            <div class="container">
                <h1>Our Sustainable Development Goals</h1>
                <div class="details">
                    <img class="climatelogo" src="../Assets/climate.png" alt="Alternate Text" />
                    <div class="more">
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                        <a href="#"><span>More About SDG</span><asp:Image ImageUrl="~/Assets/arrow-right-circle.png" ID="Image1" runat="server" />
                        </a>
                    </div>
                </div>
            </div>
        </div>

        <div class="history">
            <div class="container">
                <div class="left">
                    <img src="../Assets/history.png" alt="Alternate Text" />
                </div>
                <div class="right">
                    <h1>Our History</h1>
                    <p>Bina Nusantara University is dedicated to educating the next generation and fostering innovations that benefit Indonesian and global communities. The university supports community development and, in 2024, launched Climates to empower society. TFI focuses on education, environment, health, and welfare, aiming to improve community independence and quality of life, particularly for children. All programs align with Sustainable Development Goals (SDGs) and emphasize voluntary, sustainable, and transparent community development.</p>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
