using ProjectSE.Handler;
using ProjectSE.Model;
using System;
using System.Collections.Generic;

namespace ProjectSE.Controller
{
    public class ArticleController
    {
        public static List<MsArticle> GetArticleList()
        {
            return ArticleHandler.GetArticleList();
        }

        public static MsArticle GetArticleDetail(int articleID)
        {
            return ArticleHandler.GetArticleDetail(articleID);
        }

        public static string CheckArticle(string title, string author, string date, string time, string subtitle, string content, byte[] articleImage)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) ||
        string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time) ||
        string.IsNullOrEmpty(subtitle) || string.IsNullOrEmpty(content) || articleImage == null)
            {
                return "Please fill required field.";
            }
            if (!DateTime.TryParse(date, out DateTime articleDate))
            {
                return "Please input a valid article date.";
            }

            if (!TimeSpan.TryParse(time, out TimeSpan articleTimeSpan))
            {
                return "Please input a valid article time.";
            }

            if (articleImage == null || articleImage.Length == 0)
            {
                return "Please uplaod an article thumbnail.";
            }

            // Check if articleImage is a valid image
            if (!IsValidImage(articleImage))
            {
                return "Thumbnail must be an image.";
            }

            ArticleHandler.CreateNewArticle(title, author, articleDate, articleTimeSpan, subtitle, content, articleImage);

            return "";
        }

        private static bool IsValidImage(byte[] imageData)
        {
            // Check if the byte array is not null and starts with the correct image header
            if (!IsImageHeaderValid(imageData))
            {
                return false;
            }
            return true;
        }

        private static bool IsImageHeaderValid(byte[] imageData)
        {
            // JPEG image header: FF D8
            // PNG image header: 89 50 4E 47 0D 0A 1A 0A
            // GIF image header: 47 49 46 38

            if (imageData.Length < 2)
            {
                return false;
            }

            if ((imageData[0] == 0xFF && imageData[1] == 0xD8) ||     // JPEG
                (imageData[0] == 0x89 && imageData[1] == 0x50) ||     // PNG
                (imageData[0] == 0x47 && imageData[1] == 0x49 &&      // GIF
                imageData[2] == 0x46 && imageData[3] == 0x38))
            {
                return true;
            }

            return false;
        }
    }
}