using ProjectSE.Controller;
using ProjectSE.Model;
using System;

namespace ProjectSE.Views.Admin
{
    public partial class EditUserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string userID = Request.QueryString["id"];
                if (userID != null)
                {
                    LoadUserDetail(userID);
                }
            }
        }

        private void LoadUserDetail(string userID)
        {
            MsUser user = AuthController.GetUserByID(int.Parse(userID));
            if (user != null)
            {
                TextBoxName.Text = user.userName;
                TextBoxEmail.Text = user.userEmail;
                TextBoxAddress.Text = user.userAddress;
                TextBoxDOB.Text = user.userDOB != DateTime.MinValue ? Convert.ToDateTime(user.userDOB).ToString("yyyy-MM-dd") : "";

                if (user.userKTP == null)
                {
                    imgUserKTP1.AlternateText = "null";
                }
                else
                {
                    string base64image = Convert.ToBase64String(user.userKTP);
                    imgUserKTP1.ImageUrl = "data:image/jpeg;base64," + base64image;
                }

                UserVerifStatus.SelectedValue = user.verifStatus;
            }
        }

        protected void BtnSaveUserDetails_Click(object sender, EventArgs e)
        {
            string userID = Request.QueryString["id"];
            string userName = TextBoxName.Text.Trim();
            string userEmail = TextBoxEmail.Text.Trim();
            string userAddress = TextBoxAddress.Text.Trim();
            string verifStatus = UserVerifStatus.SelectedValue;
            string response = AuthController.CheckDetail(int.Parse(userID), userName, userEmail, userAddress, TextBoxDOB.Text, verifStatus);
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
            string userID = Request.QueryString["id"];
            bool success = AuthController.DeleteKTPUser(int.Parse(userID));

            if (success)
            {
                imgUserKTP1.ImageUrl = "";
                LabelError.Text = "Image deleted successfully.";
            }
            else
            {
                LabelError.Text = "Failed to delete image.";
            }
        }

    }
}