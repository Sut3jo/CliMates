<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="ProjectSE.Views.ProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/ProfilePageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container">
            <div class="form">
                <div class="txt">
                    <h3>Profile</h3>
                </div>

                <div class="inputs">
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelName" runat="server" Text="Username"></asp:Label>
                        <asp:TextBox ID="TextBoxName" runat="server" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelEmail" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="TextBoxEmail" runat="server" type="email" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelAddress" runat="server" Text="Address"></asp:Label>
                        <asp:TextBox ID="TextBoxAddress" runat="server" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelDOB" runat="server" Text="Date of Birth"></asp:Label>
                        <asp:TextBox ID="TextBoxDOB" runat="server" type="date" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelVerif" runat="server" Text="Identity Status"></asp:Label>
                        <asp:TextBox ID="TextBoxVerif" runat="server" Enabled="false"></asp:TextBox>
                        <span id="verifhere" runat="server" visible="false">Please verify your identity <a href="VerifPage.aspx">here</a></span>
                        <span id="wait" runat="server" visible="false"> Please wait for approval</span>
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="errorMessage" ID="LabelError" runat="server" Text="" Visible="false"></asp:Label>
                    </div>
                </div>
                <div class="update" runat="server" id="update" visible="true">
                    <asp:Button CssClass="ButtonEdit" ID="ButtonEdit" runat="server" Text="Edit Profile" OnClick="ButtonEdit_Click"/>
                </div>
                <div class="edit" runat="server" id="edit" visible="false">
                    <asp:Button CssClass="ButtonCancel" ID="ButtonCancel" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />
                    <asp:Button CssClass="ButtonSubmit" ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
                </div>

            </div>
        </div>
    </div>
</asp:Content>
