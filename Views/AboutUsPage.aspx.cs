using ProjectSE.Controller;
using System;

namespace ProjectSE.Views
{
    public partial class AboutUsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AuthController.UserIsAdmin())
            {
                Response.Redirect("DashboardPage.aspx");
            }
        }
    }
}