using ProjectSE.Model;

namespace ProjectSE.Factory
{
    public class ParticipantFactory
    {
        public static MsParticipant CreateParticipant(int userID, int activityID)
        {
            MsParticipant participant = new MsParticipant
            {
                userID = userID,
                activityID = activityID,
            };

            return participant;
        }
    }
}