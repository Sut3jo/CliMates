using ProjectSE.Factory;
using ProjectSE.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectSE.Repository
{
    public class ActivityRepository
    {
        private static DatabaseEntities db = DBSingleton.GetInstances();

        public static List<MsActivity> GetAllActivity()
        {
            return (from x in db.MsActivities select x).ToList();
        }
        public static List<MsActivity> GetOnGoingActivityList()
        {
            return (from x in db.MsActivities where x.activityStatus == "On Going" select x).ToList();
        }
        public static MsActivity GetActivityDetail(int activityID)
        {
            return (from x in db.MsActivities where x.activityID == activityID select x).FirstOrDefault();
        }

        public static void AddNewEvent(string activityTitle, int activityCapacity, string activityLocation, string activityDescription, string activityRequirement, string activityOrganizer, DateTime activityEventDate, TimeSpan activityEventTime, DateTime activityStartDate, DateTime activityEndDate, byte[] activityImage)
        {
            MsActivity newActivity = ActivityFactory.CreateActivity(GenerateID(), activityTitle, activityCapacity, activityLocation, activityDescription, activityRequirement, activityOrganizer, "On Going", activityEventDate, activityEventTime, activityStartDate, activityEndDate, activityImage);
            db.MsActivities.Add(newActivity);
            db.SaveChanges();
        }

        public static void RequestNewEvent(string activityTitle, int activityCapacity, string activityLocation, string activityDescription, string activityRequirement, string activityOrganizer, DateTime activityEventDate, TimeSpan activityEventTime, DateTime activityStartDate, DateTime activityEndDate, byte[] activityImage)
        {
            MsActivity newActivity = ActivityFactory.CreateActivity(GenerateID(), activityTitle, activityCapacity, activityLocation, activityDescription, activityRequirement, activityOrganizer, "Request", activityEventDate, activityEventTime, activityStartDate, activityEndDate, activityImage);
            db.MsActivities.Add(newActivity);
            db.SaveChanges();
        }

        public static int GetLastID()
        {
            return (from x in db.MsActivities select x.activityID).ToList().LastOrDefault();
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

        public static void DoUpdateActivity(int id, string title, int capacity, string location, string description, string requirement, string organizer, DateTime eventDate, TimeSpan eventTime, DateTime startDate, DateTime endDate, string status)
        {
            MsActivity activity = (from x in db.MsActivities where x.activityID == id select x).FirstOrDefault();

            if (activity != null)
            {
                activity.activityID = id;
                activity.activityTitle = title;
                activity.activityCapacity = capacity;
                activity.activityLocation = location;
                activity.activityDescription = description;
                activity.activityDate = eventDate;
                activity.activityTime = eventTime;
                activity.activityStartRegistration = startDate;
                activity.activityEndRegistration = endDate;
                activity.activityCreator = organizer;
                activity.activityRequirements = requirement;
                activity.activityStatus = status;

                db.SaveChanges();
            }

        }

        public static bool DeleteThumbnail(int userID)
        {
            MsActivity activity = GetActivityDetail(userID);
            if (activity != null)
            {
                activity.activityImage = null;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}