using System;

namespace ProjectSE.Views
{
    public partial class DonationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("DonationRequestPage.aspx");
        }
    }
}