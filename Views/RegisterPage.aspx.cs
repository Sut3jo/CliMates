using ProjectSE.Controller;
using System;

namespace ProjectSE.Views
{
    public partial class RegisterPage : System.Web.UI.Page
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

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            string userName = TextBoxName.Text;
            string userPassword = TextBoxPassword.Text;
            string userEmail = TextBoxEmail.Text;
            string userAddress = TextBoxAddress.Text;

            string response = RegisterController.CheckRegister(userName, userEmail, userPassword, userAddress, TextBoxDOB.Text);

            if (response != "")
            {
                LabelError.Text = response;
                LabelError.Visible = true;
                return;
            }
            Response.Write("<script>window.alert('Successfully Registered'); window.location='RegisterPage.aspx'</script>");
        }
    }
}