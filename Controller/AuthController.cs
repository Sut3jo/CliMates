using ProjectSE.Handler;
using ProjectSE.Model;
using System;
using System.Collections.Generic;
using System.Web;

namespace ProjectSE.Controller
{
    public class AuthController
    {
        public static List<MsUser> GetMsUsersList()
        {
            return UserHandler.GetMsUsersList();
        }
        public static MsUser GetUserByID(int userID)
        {
            return UserHandler.GetUserByID(userID);
        }
        public static string DoCheckLogin(string userName, string password)
        {
            string response = "";

            if (string.IsNullOrEmpty(userName))
            {
                response = "Email must be filled";
                return response;
            }

            if (string.IsNullOrEmpty(password))
            {
                response = "Password must be filled";
                return response;
            }
            MsUser user = AuthController.DoLogin(userName, password);

            if (user == null)
            {
                response = "Login failed. Please try again.";
                return response;
            }

            return response;
        }

        public static MsUser DoLogin(string userName, string userPassword)
        {
            MsUser user = UserHandler.DoLogin(userName, userPassword);
            if (user != null)
            {
                HttpContext.Current.Session.Add("userID", user.userID);
                HttpContext.Current.Session.Add("userName", user.userName);
                HttpContext.Current.Session.Add("userRole", user.userRole);
                HttpContext.Current.Session.Add("userEmail", user.userEmail);
            }

            return user;
        }

        public static bool DeleteKTPUser(int userID)
        {
            return UserHandler.DeleteKTPUser(userID);
        }

        public static MsUser DoLoginByGoogle(string userEmail)
        {
            MsUser user = UserHandler.DoLoginByGoogle(userEmail);
            if (user != null)
            {
                HttpContext.Current.Session.Add("userID", user.userID);
                HttpContext.Current.Session.Add("userName", user.userName);
                HttpContext.Current.Session.Add("userRole", user.userRole);
                HttpContext.Current.Session.Add("userEmail", user.userEmail);
            }
            return user;
        }

        public static void UserVerifStatus(int userID, string verifStatus)
        {
            UserHandler.UserVerifStatus(userID, verifStatus);
        }

        public static bool UserIsLoggedIn()
        {
            return HttpContext.Current.Session["userID"] != null;
        }

        public static bool UserIsAdmin()
        {
            if (UserIsLoggedIn())
            {
                if (HttpContext.Current.Session["userRole"].ToString() == "Admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static string CheckDetail(int userID, string userName, string userEmail, string userAddress, string userDOB, string verifStatus)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return "Name must be filled";
            }

            if (string.IsNullOrEmpty(userEmail))
            {
                return "Email must be filled";
            }

            if (string.IsNullOrEmpty(userAddress))
            {
                return "Address must be filled";
            }

            if (!DateTime.TryParse(userDOB, out DateTime dob) || (DateTime.Now.Year - dob.Year) < 17)
            {
                return "Must be atleast 17 Years Old";
            }
            MsUser CheckUserName = UserHandler.GetUserByUserName(userName);

            if (CheckUserName != null && CheckUserName.userID != userID)
            {
                return "UserName already exists";
            }
            MsUser checkUserEmail = UserHandler.GetUserByEmail(userEmail);

            if (checkUserEmail != null && checkUserEmail.userID != userID)
            {
                return "Email already exists";
            }

            UserHandler.DoUpdateUser(userID, userName, userEmail, userAddress, dob, verifStatus);
            return "";
        }
        public static string CheckUpdateProfile(int userID, string userName, string userEmail, string userAddress, string userDOB, string verifStatus)
        {

            if (string.IsNullOrEmpty(userName))
            {
                return "Name must be filled";
            }

            if (string.IsNullOrEmpty(userEmail))
            {
                return "Email must be filled";
            }

            if (string.IsNullOrEmpty(userAddress))
            {
                return "Address must be filled";
            }

            if (!DateTime.TryParse(userDOB, out DateTime dob) || (DateTime.Now.Year - dob.Year) < 17)
            {
                return "Must be atleast 17 Years Old";
            }

            MsUser CheckUserName = UserHandler.GetUserByUserName(userName);

            if (CheckUserName != null && CheckUserName.userID != userID)
            {
                return "UserName already exists";
            }
            MsUser checkUserEmail = UserHandler.GetUserByEmail(userEmail);

            if (checkUserEmail != null && checkUserEmail.userID != userID)
            {
                return "Email already exists";
            }

            UserHandler.DoUpdateUser(userID, userName, userEmail, userAddress, dob, verifStatus);
            HttpContext.Current.Session["userEmail"] = userEmail;
            HttpContext.Current.Session["userName"] = userName;

            return "";
        }
    }

}