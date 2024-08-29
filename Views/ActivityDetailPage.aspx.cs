using Google.Apis.Util;
using ProjectSE.Controller;
using ProjectSE.Model;
using System;
using System.Linq;

namespace ProjectSE.Views
{
    public partial class ActivityDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["activityID"] != null)
                {
                    int activityID = int.Parse(Request.QueryString["activityID"]);
                    LoadActivityDetail(activityID);
                }
            }
        }

        private void LoadActivityDetail(int activityID)
        {
            MsActivity activity = ActivityController.GetActivityDetail(activityID);

            if (activity != null)
            {
                LabelJudul.Text = activity.activityTitle + ' ' + '-';
                LabelOrganizer.Text = "Organized By " + activity.activityCreator;
                LabelLocation.Text = activity.activityLocation;
                LabelStart.Text = activity.activityStartRegistration.ToString("yyyy/MM/dd");
                LabelEnd.Text = activity.activityEndRegistration.ToString("yyyy/MM/dd");
                LabelDate.Text = activity.activityDate.ToString("yyyy/MM/dd");
                LabelTime.Text = activity.activityTime.ToString("hh\\:mm");
                LabelCurrent.Text = activity.activityCurrentParticipants.ToString();
                LabelCapacity.Text = activity.activityCapacity.ToString();

                if (activity.activityImage != null)
                {
                    string base64image = Convert.ToBase64String(activity.activityImage);
                    activityimage.Src = "data:image/jpeg;base64," + base64image;
                }
                else
                {
                    activityimage.Src = "../Assets/climateactionlogo.png";
                }

                string formatdescription = FormatTextWithParagraphs(activity.activityDescription);
                LabelDescription.Text = formatdescription;

                string formattedText = FormatTextWithLineBreaks(activity.activityRequirements);
                LabelReq.Text = formattedText;
            }
        }

        private string FormatTextWithLineBreaks(string text)
        {
            string[] parts = System.Text.RegularExpressions.Regex.Split(text, @"(?=\d+\.)");

            if (parts[0].Trim() == string.Empty)
            {
                parts = parts.Skip(1).ToArray();
            }

            return string.Join("<br/>", parts);
        }

        private string FormatTextWithParagraphs(string text)
        {
            string[] lines = text.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            // Wrap each line in <p> tags and join them
            return string.Join("", lines.Select(line => $"<p class=\"labelcontent\">{line.Trim()}</p> <br/>"));
        }

        protected void ButtonJoin_Click(object sender, EventArgs e)
        {
            if (Session["userID"] == null)
            {
                Response.Write("<script>window.alert('Login to join events.'); window.location='LoginPage.aspx'</script>");
                return;
            }

            int userID = int.Parse(Session["userID"].ToString());
            int activityID = int.Parse(Request.QueryString["activityID"]);
            MsActivity activity = ActivityController.GetActivityDetail(activityID);

            MsUser user = AuthController.GetUserByID(userID);

            if (user != null)
            {
                if (user.verifStatus != "Verified")
                {
                    Response.Write("<script>window.alert('You must verify your account to join event.'); window.location='ProfilePage.aspx'</script>");
                    return;
                }
            }

            MsParticipant checkParticipant = ParticipantController.CheckExistingParticipant(userID, activityID);

            if (checkParticipant != null)
            {
                Response.Write("<script>window.alert('You already joined the event.'); window.location='ActivityDetailPage.aspx?activityID=" + activityID + "';</script>");
                return;
            }

            if (activity.activityCurrentParticipants >= activity.activityCapacity)
            {
                Response.Write("<script>window.alert('The Event is full.'); window.location='ActivityDetailPage.aspx?activityID=" + activityID + "';</script>");
                return;
            }

            ParticipantController.AddParticipantToEvent(userID, activityID);
            Response.Write("<script>window.alert('Successfully join the event.'); window.location='ActivityDetailPage.aspx?activityID=" + activityID + "';</script>");
        }
    }
}