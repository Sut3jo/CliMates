using ProjectSE.Controller;
using ProjectSE.Model;
using System;
using System.Web;

namespace ProjectSE.Views
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string userID = HttpContext.Current.Session["userID"].ToString();
                if (userID != null)
                {
                    LoadUserProfile(userID);
                }
            }
        }

        private void LoadUserProfile(string userID)
        {
            MsUser user = AuthController.GetUserByID(int.Parse(userID));

            if (user != null)
            {
                TextBoxName.Text = user.userName;
                TextBoxEmail.Text = user.userEmail;
                TextBoxAddress.Text = user.userAddress;
                TextBoxDOB.Text = user.userDOB != DateTime.MinValue ? Convert.ToDateTime(user.userDOB).ToString("yyyy-MM-dd") : "";
                TextBoxVerif.Text = user.verifStatus;

                if (string.IsNullOrEmpty(TextBoxName.Text) || string.IsNullOrEmpty(TextBoxEmail.Text) || string.IsNullOrEmpty(TextBoxAddress.Text) || string.IsNullOrEmpty(TextBoxDOB.Text) || user.verifStatus == "Not Verified") 
                {
                    Response.Write("<script>window.alert('Please complete your profile')</script>");
                }

                if (user.verifStatus == "Not Verified" && user.userKTP == null)
                {
                    verifhere.Visible = true;
                    wait.Visible = false;
                }
                else if (user.verifStatus == "Pending" && user.userKTP != null)
                {
                    verifhere.Visible = false;
                    wait.Visible = true;
                }
                else
                {
                    verifhere.Visible = false;
                    wait.Visible = false;
                }
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string userID = HttpContext.Current.Session["userID"].ToString();
            string userName = TextBoxName.Text.Trim();
            string userEmail = TextBoxEmail.Text.Trim();
            string userAddress = TextBoxAddress.Text.Trim();
            string verifStatus = TextBoxVerif.Text;
            string response = AuthController.CheckUpdateProfile(int.Parse(userID), userName, userEmail, userAddress, TextBoxDOB.Text, verifStatus);
            if (response != "")
            {
                LabelError.Text = response;
                LabelError.Visible = true;
                return;
            }

            Response.Write("<script>window.alert('Successfully Updated'); window.location='ProfilePage.aspx'</script>");
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {

            Response.Redirect("Profilepage.aspx");
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxName.Enabled = true;
            TextBoxEmail.Enabled = true;
            TextBoxAddress.Enabled = true;
            TextBoxDOB.Enabled = true;
            edit.Visible = true;
            update.Visible = false;
        }
    }
}