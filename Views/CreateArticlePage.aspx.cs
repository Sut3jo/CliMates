using ProjectSE.Controller;
using System;

namespace ProjectSE.Views
{
    public partial class CreateArticlePage : System.Web.UI.Page
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
            string author = TextBoxAuthor.Text;
            string subtitle = TextBoxSub.Text;
            string content = TextBoxDescription.Text;
            string date = TextBoxDate.Text;
            string time = TextBoxTime.Text;
            byte[] uploadedimages = FileUploadThumbnail.FileBytes;

            string valid = ArticleController.CheckArticle(title, author, date, time, subtitle, content, uploadedimages);

            if (valid != "")
            {
                LabelError.Text = valid;
                LabelError.Visible = true;
                return;
            }

            Response.Write("<script>window.alert('Successfully Create Article'); window.location='CreateArticlePage.aspx'</script>");

        }
    }
}