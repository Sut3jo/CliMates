using ProjectSE.Controller;
using ProjectSE.Model;
using System;

namespace ProjectSE.Views.Admin
{
    public partial class EditActivityPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string activityID = Request.QueryString["id"];
                if (activityID != null)
                {
                    LoadActivityDetail(activityID);
                }
            }
        }

        private void LoadActivityDetail(string activityID)
        {
            MsActivity activity = ActivityController.GetActivityDetail(int.Parse(activityID));

            if (activity != null)
            {
                TextBoxTitle.Text = activity.activityTitle;
                TextBoxCreator.Text = activity.activityCreator;
                TextBoxDesc.Text = activity.activityDescription;
                TextBoxLocation.Text = activity.activityLocation;
                TextBoxStart.Text = Convert.ToDateTime(activity.activityStartRegistration).ToString("yyyy-MM-dd");
                TextBoxEnd.Text = Convert.ToDateTime(activity.activityEndRegistration).ToString("yyyy-MM-dd");
                TextBoxDate.Text = Convert.ToDateTime(activity.activityDate).ToString("yyyy-MM-dd");
                TextBoxTime.Text = activity.activityTime.ToString("hh\\:mm");
                TextBoxReq.Text = activity.activityRequirements;
                TextBoxCapacity.Text = activity.activityCapacity.ToString();


                if (activity.activityImage == null)
                {
                    thumbnail.AlternateText = "null";
                }
                else
                {
                    string base64image = Convert.ToBase64String(activity.activityImage);
                    thumbnail.ImageUrl = "data:image/jpeg;base64," + base64image;
                }

                ActivityVerifStatus.SelectedValue = activity.activityStatus;

            }
        }

        protected void BtnSaveDetails_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string title = TextBoxTitle.Text;
            string creator = TextBoxCreator.Text;
            string location = TextBoxLocation.Text;
            string description = TextBoxDesc.Text;
            string requirements = TextBoxReq.Text;
            string capacity = TextBoxCapacity.Text;
            string status = ActivityVerifStatus.SelectedValue;

            string response = ActivityController.CheckUpdateActivity(id, title, capacity, location, description, requirements, creator, TextBoxDate.Text, TextBoxTime.Text, TextBoxStart.Text, TextBoxEnd.Text, status);

            if (response != "")
            {
                LabelError.Text = response;
                LabelError.Visible = true;
                return;
            }

            Response.Write("<script>window.alert('Successfully Update'); window.location='RequestListPage.aspx'</script>");

        }

        protected void BtnDeleteImage_Click(object sender, EventArgs e)
        {
            string activityID = Request.QueryString["id"];

            MsActivity activity = ActivityController.GetActivityDetail(int.Parse(activityID));

            if (activity != null)
            {
                if (activity.activityImage != null)
                {
                    bool success = AuthController.DeleteKTPUser(int.Parse(activityID));

                    if (success)
                    {
                        thumbnail.ImageUrl = "";
                        LabelError.Text = "Image deleted successfully.";
                    }
                    else
                    {
                        LabelError.Text = "Failed to delete image.";
                    }
                }
            }
        }
    }
}