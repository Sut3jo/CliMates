<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="VerifPage.aspx.cs" Inherits="ProjectSE.Views.VerifPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/VerifyPageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container">
            <div class="form">
                <div class="txt">
                    <h3>Verify Your Identity</h3>
                </div>

                <div class="inputs">
                    <div class="rows">
                        <asp:Image CssClass="uploaded" ID="UploadedImage" AlternateText="null" runat="server" Visible="false" />
                        <asp:FileUpload ID="FileUpload" runat="server" />
                        <div class="button-rows">
                            <asp:Button CssClass="ButtonUp" ID="ButtonUpload" runat="server" Text="Upload" OnClick="ButtonUpload_Click" />
                            <asp:Button CssClass="ButtonSv" ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />
                        </div>
                        <asp:Label CssClass="errorMessage" ID="StatusLabel" runat="server" Text=""></asp:Label>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
