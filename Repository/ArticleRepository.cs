using ProjectSE.Factory;
using ProjectSE.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectSE.Repository
{
    public class ArticleRepository
    {
        private static DatabaseEntities db = DBSingleton.GetInstances();

        public static List<MsArticle> GetAllArticle()
        {
            return (from x in db.MsArticles select x).ToList();
        }

        public static MsArticle GetArticleDetail(int articleID)
        {
            return (from x in db.MsArticles where x.articleID == articleID select x).FirstOrDefault();
        }

        public static void AddNewArticle(string title, string author, DateTime Date, TimeSpan time, string subtitle, string content, byte[] articleimage)
        {
            MsArticle newArticle = ArticleFactory.CreateArticle(GenerateID(), title, author, Date, time, subtitle, content, articleimage);
            db.MsArticles.Add(newArticle);
            db.SaveChanges();
        }

        public static int GetLastID()
        {
            return (from x in db.MsArticles select x.articleID).ToList().LastOrDefault();
        }

        public static int GenerateID()
        {
            int lastid = GetLastID();

            if (lastid == 0)
            {
                return 1;
            }
            else
            {
                return lastid + 1;
            }
        }
    }
}