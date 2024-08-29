<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="EditActivityPage.aspx.cs" Inherits="ProjectSE.Views.Admin.EditActivityPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/EditActivityPageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="backgroundnavbar"></div>
    <div class="content">
        <div class="container">
            <div class="detail">
                <!-- Edit Details -->
                <h2>Edit Activity Details</h2>
                <div class="inputs">
                    <div class="split">
                        <div class="left">
                            <div class="rows">
                                <asp:Label CssClass="label" ID="LabelTitle" runat="server" Text="Title"></asp:Label>
                                <asp:TextBox CssClass="textboxcss" ID="TextBoxTitle" runat="server"></asp:TextBox>
                            </div>
                            <div class="rows">
                                <asp:Label CssClass="label" ID="LabelCreator" runat="server" Text="Creator"></asp:Label>
                                <asp:TextBox CssClass="textboxcss" ID="TextBoxCreator" runat="server"></asp:TextBox>
                            </div>
                            <div class="rows">
                                <asp:Label CssClass="label" ID="LabelDate" runat="server" Text="Date"></asp:Label>
                                <asp:TextBox CssClass="textboxcss" ID="TextBoxDate" runat="server" type="date"></asp:TextBox>
                            </div>

                            <div class="rows">
                                <asp:Label CssClass="label" ID="LabelLocation" runat="server" Text="Location"></asp:Label>
                                <asp:TextBox CssClass="textboxcss" ID="TextBoxLocation" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="right">
                            <div class="rows">
                                <asp:Label CssClass="label" ID="LabelStart" runat="server" Text="Start Registration"></asp:Label>
                                <asp:TextBox CssClass="textboxcss" ID="TextBoxStart" runat="server" type="date"></asp:TextBox>
                            </div>
                            <div class="rows">
                                <asp:Label CssClass="label" ID="LabelEnd" runat="server" Text="End Registration"></asp:Label>
                                <asp:TextBox CssClass="textboxcss" ID="TextBoxEnd" runat="server" type="date"></asp:TextBox>
                            </div>
                            <div class="rows">
                                <asp:Label CssClass="label" ID="LabelTime" runat="server" Text="Time"></asp:Label>
                                <asp:TextBox CssClass="textboxcss" ID="TextBoxTime" runat="server" type="time"></asp:TextBox>
                            </div>
                            <div class="rows">
                                <asp:Label CssClass="label" ID="LabelCapacity" runat="server" Text="Capacity"></asp:Label>
                                <asp:TextBox CssClass="textboxcss" ID="TextBoxCapacity" runat="server" type="number"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelDesc" runat="server" Text="Description"></asp:Label>
                        <asp:TextBox CssClass="textboxDescReqcss" ID="TextBoxDesc" runat="server" TextMode="MultiLine" placeholder="Max. 300 words"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="label" ID="LabelRequirement" runat="server" Text="Requirements"></asp:Label>
                        <asp:TextBox CssClass="textboxDescReqcss" ID="TextBoxReq" runat="server" TextMode="MultiLine" placeholder="Max. 300 words"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <label class="label" for="ddlActivityVerifStatus">Status</label>
                        <asp:DropDownList ID="ActivityVerifStatus" runat="server" CssClass="dropdown">
                            <asp:ListItem Value="Request">Request</asp:ListItem>
                            <asp:ListItem Value="On Going">On Going</asp:ListItem>
                            <asp:ListItem Value="Completed">Completed</asp:ListItem>
                            <asp:ListItem Value="Rejected">Rejected</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="rows">
                        <label class="label" for="fileUserKTP">Thumbnail</label>
                        <asp:Image ID="thumbnail" runat="server" AlternateText="thumbnail" CssClass="thumbnail" />
                        <asp:Button ID="btnDeleteImage" runat="server" Text="Delete Thumbnail" OnClick="BtnDeleteImage_Click" CssClass="ButtonDelete" />
                    </div>
                    <div class="rows">
                        <asp:Label CssClass="errorMessage" ID="LabelError" runat="server" Text="" Visible="false"></asp:Label>
                    </div>
                </div>

                <asp:Button CssClass="ButtonSave" ID="BtnSaveDetails" runat="server" Text="Save Details" OnClick="BtnSaveDetails_Click" />
            </div>
        </div>
    </div>
</asp:Content>
