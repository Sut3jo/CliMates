using ProjectSE.Controller;
using ProjectSE.Model;
using System;
using System.Web;

namespace ProjectSE.Views
{
    public partial class EventRequestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AuthController.UserIsAdmin())
            {
                Response.Redirect("DashboardPage.aspx");
            }
        }

        protected void ButtonRequest_Click(object sender, EventArgs e)
        {
            if (!AuthController.UserIsLoggedIn())
            {
                Response.Write("<script>window.alert('Please login first.'); window.location='LoginPage.aspx'</script>");
                return;
            }
            int userID = int.Parse(HttpContext.Current.Session["userID"].ToString());

            MsUser user = AuthController.GetUserByID(userID);

            if (user != null && user.verifStatus != "Verified")
            {
                Response.Write("<script>window.alert('You must verify your account to request event.'); window.location='ProfilePage.aspx'</script>");
                return;
            }
            string title = TextBoxTitle.Text;
            string capacity = TextBoxCapacity.Text;
            string location = TextBoxLocation.Text;
            string description = TextBoxDescription.Text;
            string requirement = TextBoxReq.Text;
            string organizer = txtOthers.Text;
            string eventDate = TextBoxDate.Text;
            string eventTime = TextBoxTime.Text;
            string startDate = TextBoxStart.Text;
            string endDate = TextBoxEnd.Text;
            bool isCheck = CheckBoxAgree.Checked;
            byte[] articleImage = FileUploadThumbnail.FileBytes;


            string valid = ActivityController.CheckActivity(title, capacity, location, description, requirement, organizer, eventDate, eventTime, startDate, endDate, articleImage);

            if (valid != "")
            {
                LabelError.Text = valid;
                LabelError.Visible = true;
                return;
            }

            if (!isCheck)
            {
                LabelError.Text = "Please agree to the terms and conditions.";
                LabelError.Visible = true;
                return;
            }

            Response.Write("<script>window.alert('Successfully Request Event'); window.location='EventRequestPage.aspx'</script>");
        }
    }
}