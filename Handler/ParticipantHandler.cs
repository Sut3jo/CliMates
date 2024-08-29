using ProjectSE.Model;
using ProjectSE.Repository;

namespace ProjectSE.Handler
{
    public class ParticipantHandler
    {
        public static MsParticipant CheckExistingParticipant(int userID, int activityID)
        {
            return ParticipantRepository.CheckExistingParticipant(userID, activityID);
        }
        public static void AddParticipantToEvent(int userID, int activityID)
        {
            ParticipantRepository.AddParticipantToEvent(userID, activityID);
        }
    }
}