using ProjectSE.Controller;
using System;

namespace ProjectSE.Views.Admin
{
    public partial class DashboardPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!AuthController.UserIsAdmin())
            {
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}