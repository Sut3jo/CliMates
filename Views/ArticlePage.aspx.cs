using ProjectSE.Controller;
using ProjectSE.Model;
using System;
using System.Collections.Generic;

namespace ProjectSE.Views
{
    public partial class ArticlePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AuthController.UserIsAdmin())
            {
                Response.Redirect("DashboardPage.aspx");
            }
            if (!IsPostBack)
            {
                LoadArticle();
            }
        }

        private void LoadArticle()
        {
            List<MsArticle> articles = ArticleController.GetArticleList();

            if (articles != null && articles.Count > 0)
            {
                rptVolunteerActivities.DataSource = articles;
                rptVolunteerActivities.DataBind();
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

        protected string TruncateText(string text, int maxLength)
        {
            if (text.Length > maxLength)
            {
                return text.Substring(0, maxLength) + "...";
            }
            else
            {
                return text;
            }
        }
    }
}