<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="DonationRequestPage.aspx.cs" Inherits="ProjectSE.Views.DonationRequestPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/DonationRequestPageCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form">
        <div class="content1">
            <div class="container1">
                <div class="title">
                    <h3>Donation Request Form</h3>
                </div>
                <div class="split">
                    <div class="left">
                        <div class="input">
                            <div class="inputlabel">
                                <asp:Label ID="Label1" runat="server" Text="Donation Title" CssClass="inputlabel"></asp:Label>
                            </div>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="text" BackColor="#ECECEC" PlaceHolder="e.g Vegetables, food, and water for Palestinian families " Font-Size="10"></asp:TextBox>
                        </div>
                        <div class="input">
                            <div class="inputlabel">
                                <asp:Label ID="Label2" runat="server" Text="Donation Goal" CssClass="inputlabel"></asp:Label>
                            </div>
                            <asp:TextBox ID="TextBox2" runat="server" CssClass="text" BackColor="#ECECEC" Font-Size="10" PlaceHolder="e.g Vegetables, food, and water for Palestinian families "></asp:TextBox>
                        </div>
                        <div class="input">
                            <div class="inputlabel">
                                <asp:Label ID="Label3" runat="server" Text="Donation Thumbnail" CssClass="inputlabel"></asp:Label>
                            </div>
                            <asp:TextBox ID="TextBox3" runat="server" CssClass="textthumb" BackColor="#ECECEC" Font-Size="10" PlaceHolder="Input image (max. 25MB) "></asp:TextBox>
                        </div>
                    </div>
                    <div class="right">
                        <asp:Label ID="Label4" runat="server" Text="Donation Organizer" CssClass="inputlabel"></asp:Label>
                        <div class="choice">
                            <asp:RadioButtonList CssClass="rbl-options" ID="rblOptions" runat="server" AutoPostBack="true">
                                <asp:ListItem Text="Organization/Foundation" Value="Organization" Selected="True"></asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:TextBox CssClass="textbox" ID="txtOthers" runat="server" Visible="true" placeholder="Input Organization/Foundation Name"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="desc">
                    <div class="inputlabel">
                        <asp:Label ID="Label5" runat="server" Text="Description"></asp:Label>
                    </div>
                    <textarea id="TextArea1" cols="100" rows="6" aria-hidden="True" aria-live="polite" style="border-width: 0px; background-color: #ECECEC; border-top-style: 0; border-right-style: 0; border-bottom-style: 0; border-left-style: 0; color: #000000; border-radius: 5px; padding: 8px;" placeholder="Max. 300 Word" class="desctext"></textarea>
                    <p>* Pressing “Me” in Donation Organizer means you take the responsible as the organizer</p>
                    <p>* Climates have the right to decline the request if there are any suspiciousness</p>
                    <div class="agree">
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                        <asp:Label ID="Label6" runat="server" Text="Agree" Font-Size="8"></asp:Label>
                    </div>
                </div>
                <div class="submit">
                    <asp:Button ID="Button1" runat="server" Text="Request Donation" BackColor="#153E35" CssClass="Button" Font-Bold="True" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
