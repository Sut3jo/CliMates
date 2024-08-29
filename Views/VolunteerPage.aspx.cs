using ProjectSE.Controller;
using ProjectSE.Model;
using System;
using System.Collections.Generic;

namespace ProjectSE.Views
{
    public partial class VolunteerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AuthController.UserIsAdmin())
            {
                Response.Redirect("DashboardPage.aspx");
            }
            if (!IsPostBack)
            {
                LoadActivities();
            }
        }

        private void LoadActivities()
        {
            List<MsActivity> activities = ActivityController.GetOnGoingActivityList();

            if (activities != null && activities.Count > 0)
            {
                lists.Visible = true;
                rptVolunteerActivities.DataSource = activities;
                rptVolunteerActivities.DataBind();
            }
            else
            {
                lists.Visible = false;
            }
        }

        protected string GetBase64Image(object articleImage)
        {
            if (articleImage != null && articleImage is byte[])
            {
                byte[] imageData = (byte[])articleImage;
                string base64String = Convert.ToBase64String(imageData);
                return "data:image/jpeg;base64," + base64String;
            }
            else
            {
                return "default_base64_image_string";
            }
        }

        public string TruncateString(string input, int maxLength)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return input.Length <= maxLength ? input : input.Substring(0, maxLength) + "...";
        }

        protected void ButtonStart_Click(object sender, EventArgs e)
        {
            Response.Redirect("EventRequestPage.aspx");
        }
    }
}