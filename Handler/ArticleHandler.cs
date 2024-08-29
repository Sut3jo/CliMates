using ProjectSE.Model;
using ProjectSE.Repository;
using System;
using System.Collections.Generic;

namespace ProjectSE.Handler
{
    public class ArticleHandler
    {
        public static List<MsArticle> GetArticleList()
        {
            return ArticleRepository.GetAllArticle();
        }

        public static MsArticle GetArticleDetail(int articleID)
        {
            return ArticleRepository.GetArticleDetail(articleID);
        }

        public static void CreateNewArticle(string title, string author, DateTime Date, TimeSpan time, string subtitle, string content, byte[] articleimage)
        {
            ArticleRepository.AddNewArticle(title, author, Date, time, subtitle, content, articleimage);
        }
    }
}