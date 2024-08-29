using ProjectSE.Model;
using ProjectSE.Repository;
using System;
using System.Collections.Generic;

namespace ProjectSE.Handler
{
    public class ActivityHandler
    {
        public static List<MsActivity> GetAllActivity()
        {
            return ActivityRepository.GetAllActivity();
        }

        public static List<MsActivity> GetOnGoingActivityList()
        {
            return ActivityRepository.GetOnGoingActivityList();
        }
        public static MsActivity GetActivityDetail(int activityID)
        {
            return ActivityRepository.GetActivityDetail(activityID);
        }

        public static void DoCreateEvent(
           string activityTitle, int activityCapacity, string activityLocation, string activityDescription, string activityRequirement, string activityOrganizer, DateTime activityEventDate, TimeSpan activityEventTime, DateTime activityStartDate, DateTime activityEndDate, byte[] activityImage)
        {
            ActivityRepository.AddNewEvent(activityTitle, activityCapacity, activityLocation, activityDescription, activityRequirement, activityOrganizer, activityEventDate, activityEventTime, activityStartDate, activityEndDate, activityImage);
        }

        public static void DoRequestEvent(string activityTitle, int activityCapacity, string activityLocation, string activityDescription, string activityRequirement, string activityOrganizer, DateTime activityEventDate, TimeSpan activityEventTime, DateTime activityStartDate, DateTime activityEndDate, byte[] activityImage)
        {
            ActivityRepository.RequestNewEvent(activityTitle, activityCapacity, activityLocation, activityDescription, activityRequirement, activityOrganizer, activityEventDate, activityEventTime, activityStartDate, activityEndDate, activityImage);
        }

        public static void DoUpdateActivity(int id, string title, int capacity, string location, string description, string requirement, string organizer, DateTime eventDate, TimeSpan eventTime, DateTime startDate, DateTime endDate, string status)
        {
            ActivityRepository.DoUpdateActivity(id, title, capacity, location, description, requirement, organizer, eventDate, eventTime, startDate, endDate, status);
        }
        public static bool DeleteThumbnail(int userID)
        {
            return ActivityRepository.DeleteThumbnail(userID);
        }
    }
}