<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="ArticlePage.aspx.cs" Inherits="ProjectSE.Views.ArticlePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/ArticlePageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner">
        <div class="container">
            <h1>Explore Our Articles</h1>
        </div>
    </div>
    <div class="content">
        <div class="container">
            <asp:Repeater ID="rptVolunteerActivities" runat="server">
                <ItemTemplate>
                    <%-- ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ --%>
                    <div class="article-card">
                        <div class="articleimage">
                            <img src="<%# GetBase64Image((byte[])Eval("ArticleImage")) %>" alt="null" />
                        </div>

                        <div class="articledetail">
                            <div class="top-content">
                                <div class="authoranddate">
                                    <p class="author"> <%# Eval("ArticleAuthor") %> -</p
                                    <p class="date"><%# Eval("ArticleDate", "{0:dddd, dd MMMM yyyy}") %></p>
                                </div>
                                <h1><%# Eval("ArticleTitle") %></h1>
                                <p><%# TruncateText(Eval("ArticleSubtitle").ToString(), 100) %></p>
                            </div>
                            <div class="btm-content">
                                <a href='<%# "ArticleDetailPage.aspx?articleID=" + Eval("ArticleID") %>'>Read More</a>
                            </div>
                        </div>
                    </div>
                    <%-- ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ --%>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>
