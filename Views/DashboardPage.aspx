<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="DashboardPage.aspx.cs" Inherits="ProjectSE.Views.Admin.DashboardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/DashboardPageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="backgroundnavbar"></div>
    <div class="content">
        <div class="container">
            <div class="box">
                <h1>Dashboard</h1>
                <p>Hello, welcome to admin dashboard.</p>
            </div>
        </div>
    </div>
</asp:Content>
