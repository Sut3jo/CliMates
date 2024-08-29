using ProjectSE.Model;
using System;

namespace ProjectSE.Factory
{
    public class ArticleFactory
    {
        public static MsArticle CreateArticle(int id, string title, string author, DateTime Date, TimeSpan time, string subtitle, string content, byte[] articleImage)
        {
            MsArticle article = new MsArticle()
            {
                articleID = id,
                articleAuthor = author,
                articleTitle = title,
                articleContent = content,
                articleSubTitle = subtitle,
                articleDate = Date,
                articleTime = time,
                articleImage = articleImage,
            };
            return article;
        }
    }
}