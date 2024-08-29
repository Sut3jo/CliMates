using ProjectSE.Handler;
using ProjectSE.Model;

namespace ProjectSE.Controller
{
    public class ParticipantController
    {
        public static MsParticipant CheckExistingParticipant(int userID, int activityID)
        {
            return ParticipantHandler.CheckExistingParticipant(userID, activityID);
        }
        public static void AddParticipantToEvent(int userID, int activityID)
        {
            ParticipantHandler.AddParticipantToEvent(userID, activityID);
        }
    }
}