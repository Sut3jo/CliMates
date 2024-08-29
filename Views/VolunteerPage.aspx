<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="VolunteerPage.aspx.cs" Inherits="ProjectSE.Views.VolunteerPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/VolunteerPage.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner">
        <div class="container">
            <h1>More People
                <br />
                Means
                <br />
                More Impact.</h1>
        </div>
    </div>

    <div class="volunteerList">
        <div class="vol-container">
            <div class="volunteer-head">
                <h1>Join Our Volunteer Network
                    <br />
                    in Simple <span class="tiga">3</span> Steps
                </h1>
            </div>
            <div class="threesteps">
                <div class="steps">
                    <span class="angka">1</span>
                    <h1>Sign Up and be one of the climates</h1>
                </div>
                <div class="steps">
                    <span class="angka">2</span>
                    <h1>Select Events</h1>
                </div>
                <div class="steps">
                    <span class="angka">3</span>
                    <h1>Confirmation and Preparation</h1>
                </div>
                <div class="vertical-line"></div>
                <div class="done">
                    <span class="alldonetext">All Done?
                    </span>
                    <h1>Now You’re ready to go!</h1>
                </div>
            </div>

            <div class="lists" id="lists" runat="server" visible="false"> 
                <asp:Repeater ID="rptVolunteerActivities" runat="server">
                    <ItemTemplate>
                        <div class="card">
                            <div class="card-container">
                                <img class="logo" src="<%# GetBase64Image((byte[])Eval("ActivityImage")) %>" alt="null" />
                                <div class="card-detail">
                                    <h1><%# TruncateString(Eval("ActivityTitle").ToString(),50) %></h1>
                                    <div class="detail-rows">
                                        <div class="rows">
                                            <img src="../Assets/user.png" alt="Alternate Text" />
                                            <span><%# Eval("ActivityCurrentParticipants") %>/<%# Eval("ActivityCapacity") %></span>
                                        </div>
                                        <div class="rows">
                                            <img src="../Assets/clock.png" alt="Alternate Text" />
                                            <span><%# Eval("ActivityTime", "{0:hh\\:mm}") %></span>
                                        </div>
                                        <div class="rows">
                                            <img src="../Assets/calendar.png" alt="Alternate Text" />
                                            <span><%# Eval("ActivityDate", "{0:dddd, dd MMMM yyyy}") %></span>
                                        </div>
                                        <div class="rows">
                                            <img src="../Assets/map-pin.png" alt="Alternate Text" />
                                            <span><%# TruncateString(Eval("ActivityLocation").ToString(), 20) %></span>
                                        </div>
                                    </div>

                                    <div class="lastrows">
                                        <a href='<%# "ActivityDetailPage.aspx?activityID=" + Eval("ActivityID") %>'><span>Info Lengkap</span><asp:Image ImageUrl="~/Assets/arrow-right-circle.png" ID="Image1" runat="server" /></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>


        <div class="movement">
            <div class="move-container">
                <h1>Dreaming of Change?
                    <br />
                    Create Your Own Movement </h1>
                <p>
                    It's time to do more than just dream. Let's build together a volunteer movement that changes the world! Everyone has the power to ignite positive change. Whatever cause touches your heart, you can become a change agent leading the way to solutions. From caring for the environment to empowering future generations, every small step brings us closer to a greater goal. 
                </p>
                <p>
                    When you take the first step, you inspire others to join in, forming an unstoppable wave of solidarity. No need to wait. No need for permission. Start today. Be the catalyst for a new movement that brings hope and real change to our world.
                </p>

                <asp:Button ID="ButtonStart" CssClass="buttonStart" runat="server" Text="Start a Movement" OnClick="ButtonStart_Click" />

            </div>
        </div>
    </div>
</asp:Content>
