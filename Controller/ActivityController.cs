using ProjectSE.Handler;
using ProjectSE.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Web;

namespace ProjectSE.Controller
{
    public class ActivityController
    {
        public static List<MsActivity> GetAllActicity()
        {
            return ActivityHandler.GetAllActivity();
        }
        public static List<MsActivity> GetOnGoingActivityList()
        {
            return ActivityHandler.GetOnGoingActivityList();
        }
        public static MsActivity GetActivityDetail(int activityID)
        {
            return ActivityHandler.GetActivityDetail(activityID);
        }

        public static string CheckUpdateActivity(string id, string title, string capacity, string location, string description, string requirement, string organizer, string eventDate, string eventTime, string startDate, string endDate, string status)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(capacity) || string.IsNullOrWhiteSpace(location) ||
                string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(requirement) || string.IsNullOrWhiteSpace(organizer) ||
                string.IsNullOrWhiteSpace(eventDate) || string.IsNullOrWhiteSpace(eventTime) || string.IsNullOrWhiteSpace(startDate) ||
                string.IsNullOrWhiteSpace(endDate))
            {
                return "Please input all required fields.";
            }

            if (!int.TryParse(capacity, out int capacityNumber))
            {
                return "Please input valid capacity.";
            }

            // Check if eventDate is a valid date
            if (!DateTime.TryParseExact(eventDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime eventDateTime))
            {
                return "Please input valid event date in format yyyy-MM-dd.";
            }

            // Check if eventTime is a valid time
            if (!TimeSpan.TryParseExact(eventTime, "hh\\:mm", CultureInfo.InvariantCulture, out TimeSpan eventTimeSpan))
            {
                return "Please input a valid event time in format hh:mm.";
            }

            // Check if startDate and endDate are valid dates
            if (!DateTime.TryParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDateTime) ||
                !DateTime.TryParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime endDateTime))
            {
                return "Please input valid start and end registration dates in format yyyy-MM-dd.";
            }

            // Check if startDate is not later than endDate
            if (startDateTime > endDateTime)
            {
                return "Please make sure start registration date is not later than end registration date.";
            }

            // Check if eventDate is not earlier than endDate
            if (eventDateTime < endDateTime)
            {
                return "Please make sure event date is not earlier than start/end registration date.";
            }

            // Call the update method if all validations pass
            ActivityHandler.DoUpdateActivity(int.Parse(id), title, capacityNumber, location, description, requirement, organizer, eventDateTime, eventTimeSpan, startDateTime, endDateTime, status);

            return "";
        }

        public static string CheckActivity(string title, string capacity, string location, string description, string requirement, string organizer, string eventDate, string eventTime, string startDate, string endDate, byte[] activityImage)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(capacity) || string.IsNullOrWhiteSpace(location) ||
        string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(requirement) || string.IsNullOrWhiteSpace(organizer) ||
        string.IsNullOrWhiteSpace(eventDate) || string.IsNullOrWhiteSpace(eventTime) || string.IsNullOrWhiteSpace(startDate) ||
        string.IsNullOrWhiteSpace(endDate))
            {
                return "Please input all required fields.";
            }

            if (!int.TryParse(capacity, out int capacityNumber))
            {
                return "Please input valid capacity.";
            }


            // Check if eventDate is a valid date and it's not in the past
            if (!DateTime.TryParse(eventDate, out DateTime eventDateTime) || eventDateTime < DateTime.Now)
            {
                return "Please input valid event date.";
            }

            if (!TimeSpan.TryParse(eventTime, out TimeSpan eventTimeSpan))
            {
                return "Please input a valid event time.";
            }

            // Check if startDate and endDate are valid dates
            if (!DateTime.TryParse(startDate, out DateTime startDateTime) || !DateTime.TryParse(endDate, out DateTime endDateTime))
            {
                return "Please input valid start / end registration date.";
            }

            // Check if startDate is not later than endDate
            if (startDateTime > endDateTime)
            {
                return "Please make sure start registration date not later than end registration date.";
            }

            // Check if eventDate is not earlier than endDate
            if (eventDateTime < endDateTime)
            {
                return "Please make sure event date is not earlier than start/end registration date.";
            }

            if (activityImage == null || activityImage.Length == 0)
            {
                return "Please upload an article thumbnail.";
            }

            // Check if articleImage is a valid image
            if (!IsValidImage(activityImage))
            {
                return "Thumbnail must be an image.";
            }

            if (!IsValidRequirementFormat(requirement))
            {
                return "Requirement format is invalid. Please follow the correct format.";
            }

            if (HttpContext.Current.Session["userRole"].ToString() == "Admin")
            {
                ActivityHandler.DoCreateEvent(title, capacityNumber, location, description, requirement, organizer, eventDateTime, eventTimeSpan, startDateTime, endDateTime, activityImage);
            }
            else
            {
                ActivityHandler.DoRequestEvent(title, capacityNumber, location, description, requirement, organizer, eventDateTime, eventTimeSpan, startDateTime, endDateTime, activityImage);
            }
            return "";
        }

        private static bool IsValidRequirementFormat(string requirement)
        {
            // Define the regular expression pattern to match the expected format
            string pattern = @"^\d+\.\s.*?(?=\d+\.)|$";

            // Check if the requirement matches the pattern
            return Regex.IsMatch(requirement, pattern);
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

        public static bool DeleteThumbnail(int userID)
        {
            return ActivityHandler.DeleteThumbnail(userID);
        }
    }
}