using System;
using System.Web.Configuration;
using Chaperapp.Data;
using Chaperapp.Web2;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Chaperapp.Web2
{
	public class Startup
	{
		public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }
		public static Func<UserManager<IdentityUser>> UserManagerFactory { get; set; }
		public static Func<RoleManager<IdentityRole>> RoleManagerFactory { get; set; }
		public static string PublicClientId { get; private set; }

		static Startup()
		{
			PublicClientId = "self";

			UserManagerFactory = () => new EmailUserManager(new UserStore<IdentityUser>());
			RoleManagerFactory = () => new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());

			OAuthOptions = new OAuthAuthorizationServerOptions
			{
				TokenEndpointPath = new PathString("/Token"),
				Provider = new ApplicationOAuthProvider(PublicClientId, UserManagerFactory),
				AccessTokenExpireTimeSpan = TimeSpan.FromDays(30),
				AllowInsecureHttp = true
			};
		}

		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
			HandleUserAdminInitial();
		}

		// For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
		public void ConfigureAuth(IAppBuilder app)
		{
			// Enable the application to use a cookie to store information for the signed in user
			// and to use a cookie to temporarily store information about a user logging in with a third party login provider
			app.UseCookieAuthentication(new CookieAuthenticationOptions());
			app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

			// Enable the application to use bearer tokens to authenticate users
			app.UseOAuthBearerTokens(OAuthOptions);

		}

		static void HandleUserAdminInitial()
		{
			var userName = WebConfigurationManager.AppSettings[SettingsKeys.AdminAppSettingName];

			if (string.IsNullOrWhiteSpace(userName)) return;
			try
			{
				var userManager = UserManagerFactory();
				var foundUser = userManager.FindByName(userName);

				if (foundUser == null) return;

				// does the role exist?
				var roleManager = RoleManagerFactory();

				var roleExists = roleManager.RoleExists(UserRoles.Admin);
				if (!roleExists)
				{
					roleManager.Create(new IdentityRole(UserRoles.Admin));
				}

				userManager.AddToRole(foundUser.Id, UserRoles.Admin);
			}
			catch (Exception e)
			{
				System.Console.WriteLine(e.Message);
				throw e;
			}
		}
	}
}

