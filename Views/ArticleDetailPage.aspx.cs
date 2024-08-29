using ProjectSE.Controller;
using ProjectSE.Model;
using System;
using System.Linq;

namespace ProjectSE.Views
{
    public partial class ArticleDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["articleID"] != null)
                {
                    int articleID = int.Parse(Request.QueryString["articleID"]);
                    LoadArticleDetail(articleID);
                }
            }
        }

        private void LoadArticleDetail(int articleID)
        {
            MsArticle article = ArticleController.GetArticleDetail(articleID);
            if (article != null)
            {
                LabelTitle.Text = article.articleTitle;
                LabelSubTitle.Text = article.articleSubTitle;
                LabelAuthor.Text = article.articleAuthor;

                if (article.articleImage != null)
                {
                    string base64image = Convert.ToBase64String(article.articleImage);
                    ArticleImage.ImageUrl = "data:image/jpeg;base64," + base64image;
                }
                else
                {
                    ArticleImage.ImageUrl = "../Assets/climateactionlogo.png";
                }

                LabelDate.Text = Convert.ToDateTime(article.articleDate).ToString("MMMM d\\s\\t, yyyy");
                LabelTime.Text = article.articleTime.ToString("hh\\:mm") + "WIB";

                string formatcontent = FormatTextWithParagraphs(article.articleContent);

                LabelContent.Text = formatcontent;
            }
        }

        private string FormatTextWithParagraphs(string text)
        {
            string[] lines = text.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            // Wrap each line in <p> tags and join them
            return string.Join("", lines.Select(line => $"<p class=\"labelcontent\">{line.Trim()}</p> <br/>"));
        }
    }
}
