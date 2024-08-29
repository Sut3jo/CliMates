<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="EditUserPage.aspx.cs" Inherits="ProjectSE.Views.Admin.EditUserPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/EditUserPageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="backgroundnavbar"></div>
    <div class="content">
        <div class="container">
            <div class="detail">
                <!-- Edit Details -->
                <h2>Edit User Details</h2>
                <div class="inputs">
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelName" runat="server" Text="Username"></asp:Label>
                        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelEmail" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="TextBoxEmail" runat="server" type="email"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelAddress" runat="server" Text="Address"></asp:Label>
                        <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelDOB" runat="server" Text="Date of Birth"></asp:Label>
                        <asp:TextBox ID="TextBoxDOB" runat="server" type="date"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <label class="label" for="ddlUserVerifStatus">Verification Status</label>
                        <asp:DropDownList ID="UserVerifStatus" runat="server" CssClass="dropdown">
                            <asp:ListItem Value="Not Verified">Not Verified</asp:ListItem>
                            <asp:ListItem Value="Pending">Pending</asp:ListItem>
                            <asp:ListItem Value="Verified">Verified</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="rows">
                        <label class="label" for="fileUserKTP">User KTP</label>
                        <asp:Image ID="imgUserKTP1" runat="server" AlternateText="null" CssClass="ktpimage" />
                            <asp:Button ID="btnDeleteImage" runat="server" Text="Delete KTP" OnClick="BtnDeleteImage_Click" CssClass="ButtonDelete" />
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="errorMessage" ID="LabelError" runat="server" Text="" Visible="false"></asp:Label>
                    </div>
                </div>

                <asp:Button CssClass="ButtonSave" ID="BtnSaveUserDetails" runat="server" Text="Save Details" OnClick="BtnSaveUserDetails_Click" />
            </div>
        </div>
    </div>
</asp:Content>
