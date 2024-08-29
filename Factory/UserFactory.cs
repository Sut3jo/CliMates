using ProjectSE.Model;
using System;

namespace ProjectSE.Factory
{
    public class UserFactory
    {
        public static MsUser CreateUser(int userID, string userName, string userEmail, string userPassword, string userAddress, string userRole, DateTime userDOB, string verifStatus)
        {
            MsUser user = new MsUser
            {
                userID = userID,
                userName = userName,
                userEmail = userEmail,
                userPassword = userPassword,
                userAddress = userAddress,
                userRole = userRole,
                userDOB = userDOB,
                verifStatus = verifStatus
            };

            return user;
        }
    }
}