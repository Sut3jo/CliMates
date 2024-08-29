<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="EventRequestPage.aspx.cs" Inherits="ProjectSE.Views.EventRequestPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/EventCreateCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container">
            <div class="form">
                <div class="center">
                    <h1>Volunteer Event Request Form</h1>
                    <div class="inputfield">
                        <div class="left">
                            <div class="rows">
                                <div class="insider-row">
                                    <asp:Label CssClass="labeltext" ID="LabelTitle" runat="server" Text="Event Title"></asp:Label><span class="required">*</span>
                                </div>
                                <asp:TextBox CssClass="textbox" ID="TextBoxTitle" runat="server" placeholder="e.g Vegetables, food, and water for Palestinian families"></asp:TextBox>
                            </div>
                            <div class="rows">
                                <div class="insider-row">
                                    <asp:Label CssClass="labeltext" ID="LabelCapacity" runat="server" Text="Event Capacity"></asp:Label><span class="required">*</span>
                                </div>
                                <asp:TextBox CssClass="textbox" ID="TextBoxCapacity" runat="server" type="number" placeholder="e.g 100"></asp:TextBox>
                            </div>
                            <div class="rows">
                                <div class="insider-row">
                                    <asp:Label CssClass="labeltext" ID="LabelLocation" runat="server" Text="Event Location"></asp:Label><span class="required">*</span>
                                </div>
                                <asp:TextBox CssClass="textbox" ID="TextBoxLocation" runat="server" placeholder="e.g Binus Kemanggisan, Jl. Raya Kb. Jeruk No.27, RT.1/RW.9 "></asp:TextBox>
                            </div>
                            <div class="rows">
                                <div class="insider-row">
                                    <asp:Label CssClass="labeltext" ID="LabelThumbnail" runat="server" Text="Event Thumbnail"></asp:Label>
                                    <span class="required">*</span>
                                </div>
                                <asp:FileUpload ID="FileUploadThumbnail" runat="server" />
                            </div>
                        </div>
                        <div class="right">
                            <div class="rows">
                                <div class="insider-row">
                                    <asp:Label CssClass="labeltext" ID="LabelOrganizer" runat="server" Text="Event Organizer"></asp:Label><span class="required">*</span>
                                </div>
                                <asp:RadioButtonList CssClass="rbl-options" ID="rblOptions" runat="server" AutoPostBack="true">
                                    <asp:ListItem Text="Organization/Foundation" Value="Organization" Selected="True"></asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:TextBox CssClass="textbox" ID="txtOthers" runat="server" Visible="true" placeholder="Input Organization/Foundation Name"></asp:TextBox>
                            </div>
                            <div class="rows">
                                <div class="insider-row">
                                    <asp:Label CssClass="labeltext" ID="LabelDateTime" runat="server" Text="Event Date/Time"></asp:Label><span class="required">*</span>
                                </div>
                                <div class="rowstartend">
                                    <asp:TextBox CssClass="textboxDateTime" ID="TextBoxDate" runat="server" TextMode="Date" placeholder="yyyy-mm-dd"></asp:TextBox>
                                    <asp:TextBox CssClass="textboxDateTime" ID="TextBoxTime" runat="server" TextMode="Time" placeholder="hh:mm"></asp:TextBox>
                                </div>
                            </div>
                            <div class="rowstartend">
                                <div class="rows">
                                    <div class="insider-row">
                                        <asp:Label CssClass="labeltext" ID="Label1" runat="server" Text="Start Registration"></asp:Label><span class="required">*</span>
                                    </div>
                                    <asp:TextBox CssClass="textboxDateTime" ID="TextBoxStart" runat="server" TextMode="Date" placeholder="yyyy-mm-dd"></asp:TextBox>
                                </div>
                                <div class="rows">
                                    <div class="insider-row">
                                        <asp:Label CssClass="labeltext" ID="Label2" runat="server" Text="End Registration"></asp:Label><span class="required">*</span>
                                    </div>
                                    <asp:TextBox CssClass="textboxDateTime" ID="TextBoxEnd" runat="server" TextMode="Date" placeholder="yyyy-mm-dd"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="rows">
                        <div class="insider-row">
                            <asp:Label CssClass="labeltext" ID="LabelDescription" runat="server" Text="Event Description"></asp:Label><span class="required">*</span>
                        </div>
                        <asp:TextBox CssClass="textboxdesc" ID="TextBoxDescription" runat="server" TextMode="MultiLine" placeholder="Max. 300 Words"></asp:TextBox>
                    </div>
                    <div class="rows">
                        <div class="insider-row">
                            <asp:Label CssClass="labeltext" ID="LabelReq" runat="server" Text="Event Requirements"></asp:Label><span class="required">*</span>
                        </div>
                        <asp:TextBox CssClass="textboxreq" ID="TextBoxReq" runat="server" TextMode="MultiLine" placeholder="format: 1. Berusia minimal 18 tahun."></asp:TextBox>
                    </div>

                    <div class="agreements">
                        <div>
                            <p>* Climates have the right to decline the request if there are any suspiciousness</p>
                        </div>

                        <div class="checkbox">
                            <asp:CheckBox ID="CheckBoxAgree" runat="server" />
                            <span>I agree to the terms and conditions.</span>
                        </div>
                    </div>

                    <div class="errorMessage">
                        <asp:Label CssClass="labelError" ID="LabelError" runat="server" Text="" Visible="false"></asp:Label>
                    </div>
                    <div class="button">
                        <asp:Button ID="ButtonRequest" CssClass="buttonRequest" runat="server" Text="Submit Request" OnClick="ButtonRequest_Click" />
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
