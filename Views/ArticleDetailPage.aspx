<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="ArticleDetailPage.aspx.cs" Inherits="ProjectSE.Views.ArticleDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/ArticleDetailPageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner">
        <div class="container">
        </div>
    </div>
    <div class="content">
        <div class="container2">
            <div class="head">
                <asp:Label CssClass="title" ID="LabelTitle" runat="server" Text=""></asp:Label>
                <asp:Label CssClass="subtitle" ID="LabelSubTitle" runat="server" Text=""></asp:Label>
            </div>

            <div class="wrap">
                <div class="authors">
                    <span class="by">BY</span>
                    <asp:Label CssClass="author" ID="LabelAuthor" runat="server" Text=""></asp:Label>
                </div>

                <asp:Image CssClass="articleimage" ID="ArticleImage" runat="server" ImageUrl="~/Assets/climateactionlogo.png" />

                <div class="publisheddate">
                    <span class="textpublished">Published</span>
                    <asp:Label CssClass="datetime" ID="LabelDate" runat="server" Text=""></asp:Label>
                    <asp:Label CssClass="datetime" ID="LabelTime" runat="server" Text=""></asp:Label>
                </div>
            </div>


            <asp:Label CssClass="labelcontent" ID="LabelContent" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
