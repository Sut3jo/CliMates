using ProjectSE.Controller;
using ProjectSE.Handler;
using ProjectSE.Model;
using System;
using System.IO;
using System.Web;

namespace ProjectSE.Views
{
    public partial class VerifPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AuthController.UserIsLoggedIn())
            {
                string userID = HttpContext.Current.Session["userID"].ToString();
                MsUser user = AuthController.GetUserByID(int.Parse(userID));
                if (user.userKTP != null && user.userRole != "Admin")
                {
                    Response.Redirect("HomePage.aspx");
                    return;
                }
                else if (user.userRole == "Admin")
                {
                    Response.Redirect("DashboardPage.aspx");
                    return;
                }
            }
            else
            {
                Response.Redirect("HomePage.aspx");
                return;
            }
            if (!IsPostBack) ResetUploadStatus();
        }
        private void ResetUploadStatus()
        {
            UploadedImage.ImageUrl = "";
            UploadedImage.Visible = false;
            Session["UploadStatus"] = null;
            Session["FileContent"] = null;
        }

        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload.HasFile)
            {
                try
                {
                    // Check if the file size exceeds 5MB
                    if (FileUpload.PostedFile.ContentLength > 5 * 1024 * 1024) // 5MB in bytes
                    {
                        StatusLabel.Text = "The file size should not exceed 5MB.";
                        Session["UploadStatus"] = false; // Set upload status to false
                        return;
                    }

                    // Check if the uploaded file is an image
                    string fileType = FileUpload.PostedFile.ContentType;
                    if (!fileType.StartsWith("image/"))
                    {
                        StatusLabel.Text = "Only image files are allowed.";
                        Session["UploadStatus"] = false; // Set upload status to false
                        return;
                    }

                    byte[] fileContent;

                    using (Stream fileStream = FileUpload.PostedFile.InputStream)
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            fileStream.CopyTo(memoryStream);
                            fileContent = memoryStream.ToArray();
                        }
                    }
                    string base64image = Convert.ToBase64String(fileContent);
                    UploadedImage.ImageUrl = "data:image/jpeg;base64," + base64image;
                    UploadedImage.Visible = true;
                    Session["UploadStatus"] = true;
                    Session["FileContent"] = fileContent;
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "The file could not be uploaded. Error: " + ex.Message;
                    Session["UploadStatus"] = false;
                }
            }
            else
            {
                StatusLabel.Text = "Please select a file to upload.";
                Session["UploadStatus"] = false;
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (Session["UploadStatus"] != null && (bool)Session["UploadStatus"] == true)
            {
                try
                {
                    byte[] fileContent = (byte[])Session["FileContent"];
                    string userID = HttpContext.Current.Session["userID"].ToString();
                    UserHandler.UploadIdentity(fileContent, int.Parse(userID));
                    AuthController.UserVerifStatus(int.Parse(userID), "Pending");
                    Response.Write("<script>window.alert('Successfully Save'); window.location='ProfilePage.aspx'</script>");
                    ResetUploadStatus();
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "The file could not be saved. Error: " + ex.Message;
                }
            }
            else
            {
                StatusLabel.Text = "Please upload the file first before saving.";
            }
        }
    }
}