using System.Web.Http;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Roylance.Common;
using System.Threading.Tasks;
using System.Linq;
using System;
using System.Text.RegularExpressions;
using Chaperapp.DataContext;
using System.Data.Entity;
using Chaperapp.Data;
using System.Net.Http;
using Microsoft.Owin.Security.Cookies;

namespace Chaperapp.Web2.Controllers
{
	[Authorize]
	[RoutePrefix("api/Account")]
	public class AccountController : BaseApiContextController
	{
		// http://www.regular-expressions.info/email.html - thanks!
		const string EmailRegex = @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";
		const string LocalLoginProvider = "Local";

		public AccountController()
			: this(Startup.UserManagerFactory(),
				Startup.OAuthOptions.AccessTokenFormat,
				new ChaperappContext())
		{
		}

		public AccountController(
			UserManager<IdentityUser> userManager,
			ISecureDataFormat<AuthenticationTicket> accessTokenFormat,
			ChaperappContext chaperappContext)
		{
			userManager.CheckIfNull(nameof(userManager));
			accessTokenFormat.CheckIfNull(nameof(accessTokenFormat));

			this.UserManager = userManager;
			this.AccessTokenFormat = accessTokenFormat;
		}

		public UserManager<IdentityUser> UserManager { get; private set; }

		public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get; private set; }

		// GET api/Account/UserInfo
		[Route("UserInfo")]
		public async Task<IHttpActionResult> GetUserInfo()
		{
			try
			{
				var userName = User.Identity.GetUserName();

				var userInformation = await this.Context.UserModels.FirstOrDefaultAsync(information => information.UserName == userName);

				if (userInformation == null)
				{
					var newUserInfo = new UserModel
					{
						UserName = userName
					};
					this.Context.UserModels.Add(newUserInfo);
					await this.Context.SaveChangesAsync();
				}

				return this.Ok(new UserViewModel
				{
					UserName = userName,
					IsAdmin = this.User.IsInRole(UserRoles.Admin),
				});
			}
			catch (Exception e)
			{
				return this.BadRequest(e.Message);
			}
		}

		// POST api/Account/Logout
		[Route("Logout")]
		public IHttpActionResult Logout()
		{
			// todo: destroy the access token
			this.Request.GetOwinContext().Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
			return Ok();
		}

		// POST api/Account/IsLoggedIn
		[Route("IsLoggedIn")]
		public async Task<IHttpActionResult> IsLoggedIn()
		{
			var userName = this.User.Identity.GetUserName();
			if (string.IsNullOrWhiteSpace(userName))
			{
				return this.Ok(false);
			}

			return Ok(true);
		}

		[Route("UpdateProfile")]
		public async Task<IHttpActionResult> UpdateProfile(UserModel userInformation)
		{
			var userName = this.User.Identity.GetUserName();

			var foundUser =
				await this.Context.UserModels.FirstOrDefaultAsync(information => information.UserName == userName);

			if (foundUser == null)
			{
				return this.BadRequest("User not found");
			}

			foundUser.Display = userInformation.FirstName + " " + userInformation.LastName;
			foundUser.FirstName = userInformation.FirstName;
			foundUser.LastName = userInformation.LastName;

			await this.Context.SaveChangesAsync();

			return this.Ok();
		}

		// POST api/Account/ChangePassword
		[Route("ChangePassword")]
		public async Task<IHttpActionResult> ChangePassword(PasswordFunctionsModel model)
		{
			var result = await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword,
				model.NewPassword);
			
			var errorResult = GetErrorResult(result);

			if (errorResult != null)
			{
				return errorResult;
			}

			return Ok();
		}

		// POST api/Account/SetPassword
		[Route("SetPassword")]
		public async Task<IHttpActionResult> SetPassword(PasswordFunctionsModel model)
		{
			var result = await UserManager.AddPasswordAsync(User.Identity.GetUserId(), model.NewPassword);
			var errorResult = GetErrorResult(result);

			if (errorResult != null)
			{
				return errorResult;
			}

			return Ok();
		}

		// POST api/Account/ForgotPassword/
		[AllowAnonymous]
		[Route("ForgotPassword")]
		public async Task<IHttpActionResult> ForgotPassword(PasswordFunctionsModel model)
		{
			var foundUser = await this.UserManager.FindByNameAsync(model.UserName);

			if (foundUser == null)
			{
				return this.BadRequest("User doesn't exist");
			}

			await this.UserManager.RemovePasswordAsync(foundUser.Id);
			var newPassword = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 7);

			await this.UserManager.AddPasswordAsync(foundUser.Id, newPassword);

			// TODO: make generic service with parameters
			//			var message = new MailMessage();
			//			message.To.Add(foundUser.UserName);
			//			message.To.Add(ConfigurationManager.AppSettings[ChangePasswordEmailAddressName]);
			//			message.Subject = Resources.ChangeMessageSubject;
			//			message.From = new MailAddress(ConfigurationManager.AppSettings[ChangePasswordEmailAddressName]);
			//			message.Body = "Your new password is now " + newPassword;
			//
			//			var smtp = new SmtpClient("smtp.office365.com", 587)
			//			{
			//				Credentials = new NetworkCredential("<add username to web.config>", "<add password to web.config>"),
			//				EnableSsl = true
			//			};
			//			smtp.Send(message);

			return this.Ok();
		}

		// POST api/Account/Register
		[AllowAnonymous]
		[Route("Register")]
		public async Task<IHttpActionResult> Register(RegisterModel model)
		{
			// make sure email is valid
			if (!Regex.IsMatch(model.UserName, EmailRegex))
			{
				return this.BadRequest("Email is invalid");
			}

			var user = new IdentityUser
			{
				UserName = model.UserName
			};

			var result = await UserManager.CreateAsync(user, model.Password);
			var errorResult = GetErrorResult(result);

			if (errorResult != null)
			{
				return errorResult;
			}

			var existingUserInformation =
				await this.Context.UserModels.FirstOrDefaultAsync(information => information.UserName == model.UserName);

			if (existingUserInformation != null)
			{
				return this.Ok();
			}

			// does this user exist in our existing records?
			var userInformation = new UserModel
			{
				UserName = model.UserName,
				Display = model.Display
			};

			this.Context.UserModels.Add(userInformation);

			// will throw error if problem
			await this.Context.SaveChangesAsync();

			return this.Ok();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				UserManager.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Helpers
		IHttpActionResult GetErrorResult(IdentityResult result)
		{
			if (result == null)
			{
				return InternalServerError();
			}

			if (!result.Succeeded)
			{
				if (result.Errors != null && result.Errors.Any())
				{
					return this.BadRequest(result.Errors.First());
				}

				if (ModelState.IsValid)
				{
					// No ModelState errors are available to send, so just return an empty BadRequest.
					return BadRequest();
				}

				return BadRequest(ModelState);
			}

			return null;

		}

		#endregion
	}
}
