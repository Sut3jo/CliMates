<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="RequestListPage.aspx.cs" Inherits="ProjectSE.Views.RequestListPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Styles/RequestListPageCS.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="backgroundnavbar"></div>
    <div class="content">
        <div class="container">
            <div class="admin-options">
                <asp:Button ID="BtnShowUserList" runat="server" Text="Show User List" OnClick="BtnShowUserList_Click" CssClass="btn-option" />
                <asp:Button ID="BtnShowActivityList" runat="server" Text="Show Activity List" OnClick="BtnShowActivityList_Click" CssClass="btn-option" />
            </div>
            <div class="list-container">
                <%-- User List GridView --%>
                <asp:GridView CssClass="gridview" ID="GridViewUserList" runat="server" DataKeyNames="userID" AutoGenerateColumns="false" Visible="false" OnRowEditing="GridViewUserList_RowEditing" AllowSorting="true" OnSorting="GridViewUserList_Sorting">
                    <Columns>
                        <asp:BoundField DataField="userID" HeaderText="ID" SortExpression="userID"></asp:BoundField>
                        <asp:BoundField DataField="userName" HeaderText="Name"></asp:BoundField>
                        <asp:BoundField DataField="userEmail" HeaderText="Email"></asp:BoundField>
                        <asp:BoundField DataField="VerifStatus" HeaderText="Status" SortExpression="verifStatus"></asp:BoundField>
                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <div class="action-buttons">
                                    <asp:Button runat="server" ID="btnEdit" Text="Edit Detail" CssClass="action-buttonedit" CommandName="Edit" />
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <%-- Activity List GridView --%>
                <asp:GridView CssClass="gridview" ID="GridViewActivityList" runat="server" DataKeyNames="activityID" Visible="false" AutoGenerateColumns="false" OnRowEditing="GridViewActivityList_RowEditing" AllowSorting="true" OnSorting="GridViewActivityList_Sorting"> 
                    <Columns>
                        <asp:BoundField DataField="activityID" HeaderText="ID" SortExpression="activityID"></asp:BoundField>
                        <asp:BoundField DataField="activityTitle" HeaderText="Title" SortExpression="activityTitle"></asp:BoundField>
                        <asp:BoundField DataField="activityStatus" HeaderText="Status" SortExpression="activityStatus"></asp:BoundField>
                        <asp:BoundField DataField="activityDate" HeaderText="Date" DataFormatString="{0:MM/dd/yyyy}"></asp:BoundField>
                        <asp:TemplateField HeaderText="Time">
                            <ItemTemplate>
                                <%# string.Format("{0:hh\\:mm}", (TimeSpan)Eval("activityTime")) %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="activityCapacity" HeaderText="Capacity"></asp:BoundField>
                        <asp:BoundField DataField="activityStartRegistration" HeaderText="Start Registration" DataFormatString="{0:MM/dd/yyyy}" HtmlEncode="true"></asp:BoundField>
                        <asp:BoundField DataField="activityEndRegistration" HeaderText="End Registration" DataFormatString="{0:MM/dd/yyyy}" HtmlEncode="true"></asp:BoundField>

                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <div class="action-buttons">
                                    <asp:Button runat="server" ID="btnEdit" CommandName="Edit" Text="Edit Detail" CssClass="action-buttonedit" />
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

</asp:Content>
