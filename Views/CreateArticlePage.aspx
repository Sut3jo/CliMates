<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="CreateArticlePage.aspx.cs" Inherits="ProjectSE.Views.CreateArticlePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/CreateArticlePageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container">
            <div class="form">
                <div class="center">
                    <h1>Create Article</h1>
                    <div class="inputfield">
                        <div class="left">
                            <div class="rows">
                                <div class="insider-row">
                                    <asp:Label CssClass="labeltext" ID="LabelTitle" runat="server" Text="Article Title"></asp:Label><span class="required">*</span>
                                </div>
                                <asp:TextBox CssClass="textbox" ID="TextBoxTitle" runat="server" placeholder="e.g Potret Mobil Bos Rental yang Digelapkan di Pati"></asp:TextBox>
                            </div>
                            <div class="rows">
                                <div class="insider-row">
                                    <asp:Label CssClass="labeltext" ID="LabelSub" runat="server" Text="Article Subtitle"></asp:Label><span class="required">*</span>
                                </div>
                                <asp:TextBox CssClass="textbox" ID="TextBoxSub" runat="server" placeholder="e.g Polres Metro Jakarta Timur menyita mobil bos rental mobil"></asp:TextBox>
                            </div>
                            <div class="rows">
                                <div class="insider-row">
                                    <asp:Label CssClass="labeltext" ID="LabelAuthor" runat="server" Text="Article Author"></asp:Label><span class="required">*</span>
                                </div>
                                <asp:TextBox CssClass="textbox" ID="TextBoxAuthor" runat="server" placeholder="e.g Alexander - Climates News"></asp:TextBox>
                            </div>

                            <div class="rows">
                                <div class="insider-row">
                                    <asp:Label CssClass="labeltext" ID="LabelThumbnail" runat="server" Text="Article Thumbnail"></asp:Label><span class="required">*</span>
                                </div>
                                <asp:FileUpload ID="FileUploadThumbnail" runat="server" />
                            </div>
                        </div>
                        <div class="right">
                            <div class="rows">
                                <div class="insider-row">
                                    <asp:Label CssClass="labeltext" ID="LabelDateTime" runat="server" Text="Event Date/Time"></asp:Label><span class="required">*</span>
                                </div>
                                <div class="rowstartend">
                                    <asp:TextBox CssClass="textboxDateTime" ID="TextBoxDate" runat="server" TextMode="Date" placeholder="yyyy-mm-dd"></asp:TextBox>
                                    <asp:TextBox CssClass="textboxDateTime" ID="TextBoxTime" runat="server" TextMode="Time" placeholder="hh:mm"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="rows">
                        <div class="insider-row">
                            <asp:Label CssClass="labeltext" ID="LabelDescription" runat="server" Text="Article Content"></asp:Label><span class="required">*</span>
                        </div>
                        <asp:TextBox CssClass="textboxdesc" ID="TextBoxDescription" runat="server" TextMode="MultiLine" placeholder="Max. 300 Words"></asp:TextBox>
                    </div>

                    <div class="errorMessage">
                        <asp:Label CssClass="labelError" ID="LabelError" runat="server" Text="" Visible="false"></asp:Label>
                    </div>
                    <div class="button">
                        <asp:Button ID="ButtonRequest" CssClass="buttonRequest" runat="server" Text="Create Article" OnClick="ButtonRequest_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
