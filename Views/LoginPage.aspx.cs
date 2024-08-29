using ProjectSE.Controller;
using System;

namespace ProjectSE.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AuthController.UserIsLoggedIn())
            {
                if (AuthController.UserIsAdmin())
                {
                    Response.Redirect("DashboardPage.aspx");
                }
                else
                {
                    Response.Redirect("HomePage.aspx");
                }
            }
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string userNameorMail = TextBoxName.Text;
            string password = TextBoxPassword.Text;

            string response = AuthController.DoCheckLogin(userNameorMail, password);
            if (response != "")
            {
                LabelError.Text = response;
                LabelError.Visible = true;
                return;
            }

            Response.Redirect("Homepage.aspx");
        }
    }
}