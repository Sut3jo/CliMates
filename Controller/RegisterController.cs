using ProjectSE.Handler;
using ProjectSE.Model;
using System;

namespace ProjectSE.Controller
{
    public class RegisterController
    {
        public static string CheckRegister(string userName, string userEmail, string userPassword, string userAddress, string userDOB)
        {
            string response = "";

            if (string.IsNullOrEmpty(userName))
            {
                return "Name must be filled";
            }

            MsUser CheckUserName = UserHandler.GetUserByUserName(userName);
            if (CheckUserName != null)
            {
                return "UserName already exists";
            }

            if (string.IsNullOrEmpty(userEmail))
            {
                return "Email must be filled";
            }

            if (string.IsNullOrEmpty(userPassword))
            {
                return "Password must be filled";
            }

            if (string.IsNullOrEmpty(userAddress))
            {
                return "Address must be filled";
            }

            if (!DateTime.TryParse(userDOB, out DateTime dob) || (DateTime.Now.Year - dob.Year) < 17)
            {
                return "Must be atleast 17 Years Old";
            }

            MsUser checkUserEmail = UserHandler.GetUserByEmail(userEmail);

            if (checkUserEmail != null)
            {
                return "Email already exists";
            }
            else
            {
                UserHandler.DoRegister(userName, userEmail, userPassword, userAddress, "User", dob, "Not Verified");
            }
            return response;
        }
    }
}