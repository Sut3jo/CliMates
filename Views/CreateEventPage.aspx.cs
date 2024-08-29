using ProjectSE.Controller;
using System;

namespace ProjectSE.Views
{
    public partial class CreateEventPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!AuthController.UserIsAdmin())
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void ButtonRequest_Click(object sender, EventArgs e)
        {
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
            byte[] articleImage = FileUploadThumbnail.FileBytes;

            string valid = ActivityController.CheckActivity(title, capacity, location, description, requirement, organizer, eventDate, eventTime, startDate, endDate, articleImage);

            if (valid != "")
            {
                LabelError.Text = valid;
                LabelError.Visible = true;
                return;
            }

            Response.Write("<script>window.alert('Successfully Create Event'); window.location='CreateEventPage.aspx'</script>");
        }
    }
}