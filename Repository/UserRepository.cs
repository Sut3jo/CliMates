using ProjectSE.Factory;
using ProjectSE.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectSE.Repository
{
    public class UserRepository
    {
        private static DatabaseEntities db = DBSingleton.GetInstances();

        public static List<MsUser> GetMsUsersList()
        {
            return (from x in db.MsUsers where x.userRole != "Admin" select x).ToList();
        }

        public static MsUser GetUser(string userName, string userPassword)
        {
            return (from x in db.MsUsers where x.userEmail == userName && x.userPassword == userPassword select x).FirstOrDefault();
        }

        public static void UserVerifStatus(int userID, string verifStatus)
        {
            MsUser user = (from x in db.MsUsers where x.userID == userID select x).FirstOrDefault();

            user.verifStatus = verifStatus;
            db.SaveChanges();
        }
        public static MsUser GetUserByGoogle(string userEmail)
        {
            return (from x in db.MsUsers where x.userEmail == userEmail select x).FirstOrDefault();
        }
        public static MsUser GetUserByID(int userID)
        {
            return (from x in db.MsUsers where x.userID == userID select x).FirstOrDefault();
        }
        public static MsUser GetUserByUserName(string userName)
        {
            return (from x in db.MsUsers where x.userName == userName select x).FirstOrDefault();
        }

        public static bool DeleteKTPUser(int userID)
        {
            MsUser user = GetUserByID(userID);
            if (user != null)
            {
                user.userKTP = null;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public static MsUser GetUserByEmail(string userEmail)
        {
            return (from x in db.MsUsers where x.userEmail == userEmail select x).FirstOrDefault();
        }

        public static int GetLastID()
        {
            return (from x in db.MsUsers select x.userID).ToList().LastOrDefault();
        }

        private static int GenerateID()
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

        public static void AddNewUser(string userName, string userEmail, string userPassword, string userAddress, string userRole, DateTime userDOB, string verifStatus)
        {
            MsUser newUser = UserFactory.CreateUser(GenerateID(), userName, userEmail, userPassword, userAddress, userRole, userDOB, verifStatus);

            db.MsUsers.Add(newUser);
            db.SaveChanges();
        }

        public static void UploadIdentity(byte[] file, int userID)
        {
            MsUser user = (from x in db.MsUsers where x.userID == userID select x).FirstOrDefault();

            user.userKTP = file;
            db.SaveChanges();
        }

        public static void UpdateExistingUser(int userID, string userName, string userEmail, string userAddress, DateTime DOB, string verifStatus)
        {
            MsUser user = (from x in db.MsUsers where x.userID == userID select x).FirstOrDefault();
            if (user != null)
            {
                user.userName = userName;
                user.userEmail = userEmail;
                user.userAddress = userAddress;
                user.userDOB = DOB;
                user.verifStatus = verifStatus;
                db.SaveChanges();
            }
        }
    }
}