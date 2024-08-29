using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using ProjectSE.Controller;
using ProjectSE.Handler;
using ProjectSE.Model;
using System;
using System.Threading;

namespace ProjectSE.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AuthController.UserIsAdmin())
            {
                Response.Redirect("DashboardPage.aspx");
            }
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["code"]))
                {
                    HandleGoogleCallback();
                }
            }
        }

        private void HandleGoogleCallback()
        {
            string authCode = Request.QueryString["code"];
            var clientSecrets = new ClientSecrets
            {
                ClientId = "GOOGLE_CLIENT_ID",
                ClientSecret = "GOOGLE_CLIENT_SECRET"
            };

            var flow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = clientSecrets
            });

            var tokenResponse = flow.ExchangeCodeForTokenAsync("", authCode, "https://localhost:44300/Views/HomePage.aspx", CancellationToken.None).Result;

            var credential = new UserCredential(flow, "", tokenResponse);
            var oauthService = new Oauth2Service(new BaseClientService.Initializer { HttpClientInitializer = credential });
            var userInfo = oauthService.Userinfo.Get().Execute();

            string username = userInfo.Name;
            string userEmail = userInfo.Email;


            MsUser user = AuthController.DoLoginByGoogle(userEmail);

            if (user == null)
            {
                UserHandler.DoRegister(username, userEmail, "", "", "User", DateTime.MinValue, "Not Verified");
            }

            if (user.userKTP == null || user.userDOB == null || user.userAddress == null)
            {
                Response.Write("<script>window.alert('Please complete your profile.'); window.location='ProfilePage.aspx'</script>");
                return;
            }

            Response.Redirect("HomePage.aspx");
        }

        protected void ButtonJoin_Click(object sender, EventArgs e)
        {
            Response.Redirect("VolunteerPage.aspx");
        }

        protected void ButtonExplore_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArticlePage.aspx");
        }

        protected void ButtonVolunteer_Click(object sender, EventArgs e)
        {
            Response.Redirect("VolunteerPage.aspx");
        }

        protected void ButtonDonate_Click(object sender, EventArgs e)
        {
            Response.Redirect("DonationPage.aspx");
        }
    }
}