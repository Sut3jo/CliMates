using ProjectSE.Model;
using ProjectSE.Repository;
using System;
using System.Collections.Generic;

namespace ProjectSE.Handler
{
    public class UserHandler
    {
        public static List<MsUser> GetMsUsersList()
        {
            return UserRepository.GetMsUsersList();
        }
        public static MsUser DoLogin(string userName, string userPassword)
        {
            MsUser user = UserRepository.GetUser(userName, userPassword);
            return user;
        }

        public static void UserVerifStatus(int userID, string verifStatus)
        {
            UserRepository.UserVerifStatus(userID, verifStatus);
        }
        public static MsUser DoLoginByGoogle(string userEmail)
        {
            MsUser user = UserRepository.GetUserByGoogle(userEmail);
            return user;
        }
        public static MsUser GetUserByID(int userID)
        {
            MsUser user = UserRepository.GetUserByID(userID);
            return user;
        }

        public static bool DeleteKTPUser(int userID)
        {
            return UserRepository.DeleteKTPUser(userID);
        }
        public static MsUser GetUserByUserName(string userName)
        {
            MsUser user = UserRepository.GetUserByUserName(userName);
            return user;
        }
        public static MsUser GetUserByEmail(string userEmail)
        {
            MsUser user = UserRepository.GetUserByEmail(userEmail);
            return user;
        }

        public static void DoRegister(string userName, string userEmail, string userPassword, string userAddress, string userRole, DateTime userDOB, string verifStatus)
        {
            UserRepository.AddNewUser(userName, userEmail, userPassword, userAddress, userRole, userDOB, verifStatus);
        }
        public static void UploadIdentity(byte[] file, int userID)
        {
            UserRepository.UploadIdentity(file, userID);
        }

        public static void DoUpdateUser(int userID, string userName, string userEmail, string userAddress, DateTime DOB, string verifStatus)
        {
            UserRepository.UpdateExistingUser(userID, userName, userEmail, userAddress, DOB, verifStatus);
        }
    }
}