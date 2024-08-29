<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="ActivityDetailPage.aspx.cs" Inherits="ProjectSE.Views.ActivityDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/ActivityDetailCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner"></div>
    <div class="content">
        <div class="container">
            <div class="head">
                <asp:Label CssClass="judul" ID="LabelJudul" runat="server" Text="Judul"></asp:Label>
                <asp:Label CssClass="organizer" ID="LabelOrganizer" runat="server" Text="Organizer"></asp:Label>
            </div>

            <div class="insider-container">
                <div class="leftcontent">
                    <img id="activityimage" runat="server" src="../Assets/climateactionlogo.png" alt="null" />
                    <asp:Label CssClass="desc" ID="LabelDescription" runat="server" Text="Description"></asp:Label>
                </div>
                <div class="rightcontent">
                    <div class="row">
                        <p>Location</p>
                        <asp:Label ID="LabelLocation" runat="server" Text="Location"></asp:Label>
                    </div>
                    <div class="row">
                        <p>Start / End Registration</p>
                        <div>
                            <asp:Label ID="LabelStart" runat="server" Text="Start Date"></asp:Label>
                            -
                            <asp:Label ID="LabelEnd" runat="server" Text="End Date"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <p>Date and Time</p>
                        <div>
                            <asp:Label ID="LabelDate" runat="server" Text="Date"></asp:Label>
                            -
                            <asp:Label ID="LabelTime" runat="server" Text="Time"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <p>Current Participants</p>
                        <div>
                            <asp:Label ID="LabelCurrent" runat="server" Text="Current Participant"></asp:Label>
                            /
                            <asp:Label ID="LabelCapacity" runat="server" Text="Capacity"></asp:Label>
                        </div>
                    </div>
                    <div class="lastrow">
                        <p>Requirements</p>
                        <asp:Label ID="LabelReq" runat="server" Text="Requirements"></asp:Label>
                    </div>
                    <asp:Button ID="ButtonJoin" CssClass="buttonJoin" runat="server" Text="Join Activity" OnClick="ButtonJoin_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
