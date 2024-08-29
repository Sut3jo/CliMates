using ProjectSE.Controller;
using System;
using System.Web;

namespace ProjectSE.Views
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AuthController.UserIsLoggedIn())
            {
                userInfo.Visible = true;
                userProfile.InnerText = Session["userName"].ToString();
                logreg.Visible = false;
            }
            else
            {
                userInfo.Visible = false;
                logreg.Visible = true;
            }
        }

        public void DisplayCustomerNavigation()
        {
            Response.Write("<li><a href=\"HomePage.aspx\">Home</a></li>");
            Response.Write("<li><a href=\"VolunteerPage.aspx\">Volunteer</a></li>");
            Response.Write("<li><a href=\"DonationPage.aspx\">Donasi</a></li>");
            Response.Write("<li><a href=\"ArticlePage.aspx\">Article</a></li>");
            Response.Write("<li><a href=\"AboutUsPage.aspx\">Tentang Kami</a></li>");
        }

        public void DisplayAdminNavigation()
        {
            Response.Write("<li><a href=\"DashboardPage.aspx\">Dashboard</a></li>");
            Response.Write("<li><a href=\"CreateEventPage.aspx\">Create Event</a></li>");
            Response.Write("<li><a href=\"#\">Create Donation</a></li>");
            Response.Write("<li><a href=\"CreateArticlePage.aspx\">Create Article</a></li>");
            Response.Write("<li><a href=\"RequestListPage.aspx\">Request List</a></li>");
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session.Remove("userID");
            HttpContext.Current.Session.Remove("userName");
            HttpContext.Current.Session.Remove("userRole");
            Response.Redirect("~/Views/LoginPage.aspx");
        }
    }
}