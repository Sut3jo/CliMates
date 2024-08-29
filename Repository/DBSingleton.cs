using ProjectSE.Model;

namespace ProjectSE.Repository
{
    public class DBSingleton
    {
        private static DatabaseEntities db = null;

        public static DatabaseEntities GetInstances()
        {
            if (db == null)
            {
                db = new DatabaseEntities();
            }

            return db;
        }
    }
}