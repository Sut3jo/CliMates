<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="DonationPage.aspx.cs" Inherits="ProjectSE.Views.DonationPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/DonationPageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <section class="hero">
            <main class="content1">
                <div class="hero_tag">
                    <h1 class="hero_text">Even small gifts means a lot for them
                    </h1>
                </div>
            </main>
        </section>


        <div class="content2">
            <div class="donation_box">
                <h1 class="donation_box_title">DONATE TO CLIMATES</h1>
                <div class="buttons">
                    <asp:Button ID="Button1" runat="server" Text="Rp 20.000" CssClass="Buttonmoney" Font-Bold="True" Font-Size="12" />
                    <asp:Button ID="Button2" runat="server" Text="Rp 50.000" CssClass="Buttonmoney" Font-Bold="True" Font-Size="12" />
                    <asp:Button ID="Button3" runat="server" Text="Rp 100.000" CssClass="Buttonmoney" Font-Bold="True" Font-Size="12" />
                    <asp:Button ID="Button4" runat="server" Text="Rp 200.000" CssClass="Buttonmoney" Font-Bold="True" Font-Size="12" />
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="Textmoney" placeholder="Other Amount" Font-Bold="True" Font-Size="12"></asp:TextBox>
                </div>
                <div class="give">
                    <asp:Button ID="Button5" runat="server" Text="GIVE NOW" CssClass="GiveNow" Font-Bold="True" />
                </div>
            </div>
        </div>

        <div class="content3">
            <h1>DONATE TO THEM</h1>
            <div class="kotak">
                <div class="kotak-container">
                    <%--card start--%>
                    <div class="card">
                        <a href="DonationDetailPage.aspx">
                            <div class="gambar1">
                                <div class="total_donation">
                                    <h1 class="donationAmount">100.4K DONATIONS</h1>
                                </div>
                            </div>
                            <div class="cardTitle">
                                <h1 class="cardText">Pembangunan Masjid Korban Kebakaran</h1>
                            </div>
                        </a>

                        <div class="progressBar">
                            <div class="bar">
                            </div>
                        </div>
                        <div class="rupiahDonated">
                            <p>Rp. 800.000.000 donated</p>
                        </div>
                    </div>
                    <%--card end--%>
                    <%--card start--%>
                    <div class="card">
                        <a href="DonationDetailPage.aspx">
                            <div class="gambar1">
                                <div class="total_donation">
                                    <h1 class="donationAmount">100.4K DONATIONS</h1>
                                </div>
                            </div>
                            <div class="cardTitle">
                                <h1 class="cardText">Pembangunan Masjid Korban Kebakaran</h1>
                            </div>
                        </a>

                        <div class="progressBar">
                            <div class="bar">
                            </div>
                        </div>
                        <div class="rupiahDonated">
                            <p>Rp. 800.000.000 donated</p>
                        </div>
                    </div>
                    <%--card end--%>
                    <%--card start--%>
                    <div class="card">
                        <a href="DonationDetailPage.aspx">
                            <div class="gambar1">
                                <div class="total_donation">
                                    <h1 class="donationAmount">100.4K DONATIONS</h1>
                                </div>
                            </div>
                            <div class="cardTitle">
                                <h1 class="cardText">Pembangunan Masjid Korban Kebakaran</h1>
                            </div>
                        </a>

                        <div class="progressBar">
                            <div class="bar">
                            </div>
                        </div>
                        <div class="rupiahDonated">
                            <p>Rp. 800.000.000 donated</p>
                        </div>
                    </div>
                    <%--card end--%>
                    <%--card start--%>
                    <div class="card">
                        <a href="DonationDetailPage.aspx">
                            <div class="gambar1">
                                <div class="total_donation">
                                    <h1 class="donationAmount">100.4K DONATIONS</h1>
                                </div>
                            </div>
                            <div class="cardTitle">
                                <h1 class="cardText">Pembangunan Masjid Korban Kebakaran</h1>
                            </div>
                        </a>

                        <div class="progressBar">
                            <div class="bar">
                            </div>
                        </div>
                        <div class="rupiahDonated">
                            <p>Rp. 800.000.000 donated</p>
                        </div>
                    </div>
                    <%--card end--%>
                    <%--card start--%>
                    <div class="card">
                        <a href="DonationDetailPage.aspx">
                            <div class="gambar1">
                                <div class="total_donation">
                                    <h1 class="donationAmount">100.4K DONATIONS</h1>
                                </div>
                            </div>
                            <div class="cardTitle">
                                <h1 class="cardText">Pembangunan Masjid Korban Kebakaran</h1>
                            </div>
                        </a>

                        <div class="progressBar">
                            <div class="bar">
                            </div>
                        </div>
                        <div class="rupiahDonated">
                            <p>Rp. 800.000.000 donated</p>
                        </div>
                    </div>
                    <%--card end--%>
                    <%--card start--%>
                    <div class="card">
                        <a href="DonationDetailPage.aspx">
                            <div class="gambar1">
                                <div class="total_donation">
                                    <h1 class="donationAmount">100.4K DONATIONS</h1>
                                </div>
                            </div>
                            <div class="cardTitle">
                                <h1 class="cardText">Pembangunan Masjid Korban Kebakaran</h1>
                            </div>
                        </a>

                        <div class="progressBar">
                            <div class="bar">
                            </div>
                        </div>
                        <div class="rupiahDonated">
                            <p>Rp. 800.000.000 donated</p>
                        </div>
                    </div>
                    <%--card end--%>
                </div>
            </div>
        </div>

        <div class="content4">
            <div class="container4">
                <div class="headerContent4">
                    <h1 class="header_text_content_4">Got a brilliant idea to help others?
                        <br />
                        Start your own fundraiser today</h1>
                </div>
                <div class="paragraph">
                    <p>
                        It's time to do more than just dream. Let's build together a volunteer movement that changes the world!
                        <br />
                        Everyone has the power to ignite positive change. Whatever cause touches your heart,
                        <br />
                        you can become a change agent leading the way to solutions. From caring for the environment
                        <br />
                        to empowering future generations, every small step brings us closer to a greater goal.
                    </p>
                    <p>
                        When you take the first step, you inspire others to join in, forming an unstoppable wave of solidarity.
                        <br />
                        No need to wait. No need for permission. Start today. Be the catalyst for a new movement
                        <br />
                        that brings hope and real change to our world.
                    </p>
                </div>
                <div class="content4btn">
                    <asp:Button ID="Button6" runat="server" Text="Start a Movement" CssClass="btnC4" OnClick="Button6_Click"/>
                </div>
            </div>


        </div>
    </div>

</asp:Content>
