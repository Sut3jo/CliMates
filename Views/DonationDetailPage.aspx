<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="DonationDetailPage.aspx.cs" Inherits="ProjectSE.Views.DonationDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://cdn.jsdelivr.net/npm/evil-icons@1.9.0/assets/evil-icons.min.js"></script>
    <script src="https://unpkg.com/feather-icons"></script>
    <link href="../Styles/DonationDetailPageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner"></div>
    <div class="form">
        <div class="title">
            <h1>Vegetables, food, and water for Palestinian families</h1>
        </div>
        <div class="content">
            <div class="content-img">
                <img src="../Assets/content1.png" alt="" />
            </div>
            <div class="donate">
                <div class="head">
                    <div data-icon="ei-user" data-size="m" class="icon"></div>
                    <p>Climates Team is organizing this fundraiser.</p>
                </div>

                <div class="totaldonation">
                    <div class="donate-money">
                        <p><span>Rp 87.98 M</span> raised of Rp 100 M goal</p>
                    </div>
                    <div class="bar">
                        <div class="bar2"></div>
                    </div>
                    <div class="donate-desc">
                        <p>7.3K donations - <span>1.2K people supported</span></p>
                    </div>
                </div>
                <div class="button">
                    <asp:Button ID="Button1" runat="server" Text="Rp 20.000" CssClass="Buttonmoney" Font-Bold="True" Font-Size="12" />
                    <asp:Button ID="Button2" runat="server" Text="Rp 50.000" CssClass="Buttonmoney" Font-Bold="True" Font-Size="12" />
                    <asp:Button ID="Button3" runat="server" Text="Rp 100.000" CssClass="Buttonmoney" Font-Bold="True" Font-Size="12" />
                    <asp:Button ID="Button4" runat="server" Text="Rp 200.000" CssClass="Buttonmoney" Font-Bold="True" Font-Size="12" />
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="Textmoney" placeholder="Other Amount" Font-Bold="True" Font-Size="12"></asp:TextBox>
                </div>
                <div class="give">
                    <asp:Button ID="Button5" runat="server" Text="GIVE NOW" CssClass="GiveNow" Font-Bold="True" />
                </div>
                <div class="support">
                    <asp:Button ID="Button6" runat="server" Text="SUPPORT THIS FUNDRAISE" CssClass="SupportThis" Font-Bold="True" />
                </div>
            </div>
        </div>
        <div class="description">
            <p>In 2018, a group of volunteering students launched a charitable campaign entitled @Ele_Elna_Elak, which means in Arabic, “What we own, you own...” in a clear message to our belief in social solidarity and that we must all provide assistance to those in need... through... For the past six years, we have been providing food, warm clothes and blankets in the winter to thousands of families in need.</p>
            <p>
                During this war, we and our families were subjected to displacement, bombing, and starvation, as happened to all people of the Gaza Strip, but we decided to continue helping families in need under these dire circumstances, to obtain:- In 2018, a group of volunteering students launched a charitable campaign entitled @Ele_Elna_Elak, which means in Arabic, “What we own, you own...” in a clear message to our belief in social solidarity and that we must all provide assistance to those in need... through... For the past six years, we have been providing food, warm clothes and blankets in the winter to thousands of families in need.
            </p>
            <p>During this war, we and our families were subjected to displacement, bombing, and starvation, as happened to all people of the Gaza Strip, but we decided to continue helping families in need under these dire circumstances, to obtain:-</p>
        </div>
        <div class="report">
            <i class="report-logo" data-feather="alert-triangle"></i>
            <p>Report this fundraiser</p>
        </div>
        <div class="content2">
            <div class="content2-title">
                <p>
                    We Try Our Best to Be Your First, Easy, and Trusted
                <br />
                    Place to Help People 
                </p>
            </div>
            <div class="content2-box">
                <div class="content2-content">
                    <img src="../Assets/Medal First Place.png" alt="Alternate Text" />
                    <div class="content2-text">
                        <h3>First</h3>
                        <p>To be the first choice</p>
                    </div>
                </div>
                <div class="content2-content">
                    <img src="../Assets/Easy.png" alt="Alternate Text" />
                    <div class="content2-text">
                        <h3>Easy</h3>
                        <p>To be easy for every people</p>
                    </div>
                </div>
                <div class="content2-content">
                    <img src="../Assets/Trust.png" alt="Alternate Text" />
                    <div class="content2-text">
                        <h3>Trusted</h3>
                        <p>For people to feel secured</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        feather.replace();
    </script>
</asp:Content>
