using ProjectSE.Model;
using System;

namespace ProjectSE.Factory
{
    public class ActivityFactory
    {
        public static MsActivity CreateActivity(int activityID, string activityTitle, int activityCapacity, string activityLocation, string activityDescription, string activityRequirement, string activityOrganizer, string activityStatus, DateTime activityEventDate, TimeSpan activityEventTime, DateTime activityStartDate, DateTime activityEndDate, byte[] activityImage)
        {
            MsActivity activity = new MsActivity
            {
                activityID = activityID,
                activityTitle = activityTitle,
                activityCapacity = activityCapacity,
                activityCurrentParticipants = 0,
                activityLocation = activityLocation,
                activityDescription = activityDescription,
                activityRequirements = activityRequirement,
                activityStatus = activityStatus,
                activityCreator = activityOrganizer,
                activityDate = activityEventDate,
                activityTime = activityEventTime,
                activityStartRegistration = activityStartDate,
                activityEndRegistration = activityEndDate,
                activityImage = activityImage,
            };

            return activity;
        }
    }
}