<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ProjectSE.Views.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/LoginPageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container">
            <div class="form">
                <div class="txt">
                    <h3>Login</h3>
                </div>

                <div class="inputs">
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelName" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelPassword" runat="server" Text="Password"></asp:Label>
                        <asp:TextBox ID="TextBoxPassword" runat="server" type="password"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="errorMessage" ID="LabelError" runat="server" Text="" Visible="false"></asp:Label>
                    </div>
                    <div class="text">
                        <p cssclass="label">Don't have an account?</p>
                        <a href="RegisterPage.aspx">Register Here</a>
                    </div>
                </div>

                <div class="noaccount">

                    <asp:Button CssClass="ButtonLogin" ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
                </div>

                <div class="loginchoices">
                    <div class="text">
                        <span>OR</span>
                    </div>
                </div>

                <div class="choices">
                    <a href="https://accounts.google.com/o/oauth2/auth?response_type=code&client_id=371457904273-6s9l51ksicnprp1njs7brsqqh4165sr0.apps.googleusercontent.com
&redirect_uri=https://localhost:44300/Views/HomePage.aspx&scope=email%20profile">
                        <asp:ImageButton CssClass="choicesbtn" ImageUrl="~/Assets/googlelogo.png" ID="ImageButton" runat="server" Width="30px" Height="30px" />
                        <span class="button-text">Login With Google</span>
                    </a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
