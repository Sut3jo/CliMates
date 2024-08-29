using ProjectSE.Factory;
using ProjectSE.Model;
using System.Linq;

namespace ProjectSE.Repository
{
    public class ParticipantRepository
    {
        private static DatabaseEntities db = DBSingleton.GetInstances();

        public static MsParticipant CheckExistingParticipant(int userID, int activityID)
        {
            return (from x in db.MsParticipants where x.userID == userID && x.activityID == activityID select x).FirstOrDefault();
        }
        public static void AddParticipantToEvent(int userID, int activityID)
        {
            MsParticipant participant = ParticipantFactory.CreateParticipant(userID, activityID);
            db.MsParticipants.Add(participant);

            MsActivity activity = ActivityRepository.GetActivityDetail(activityID);
            activity.activityCurrentParticipants += 1;
            db.SaveChanges();
        }
    }
}