using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Chaperapp.Data;
using Chaperapp.DataContext;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Roylance.Common;

namespace Chaperapp.Web2.Controllers
{
	[Authorize]
	[RoutePrefix("api/Admin")]
	public class AdminController : BaseApiContextController
	{
		public AdminController()
			: this(
			Startup.UserManagerFactory(),
			Startup.RoleManagerFactory(),
			new ChaperappContext())
		{
		}

		public AdminController(
			UserManager<IdentityUser> userManager,
			RoleManager<IdentityRole> roleManager,
			ChaperappContext context)
			: base(context)
		{
			userManager.CheckIfNull(nameof(userManager));
			roleManager.CheckIfNull(nameof(roleManager));

			this.UserManager = userManager;
			this.RoleManager = roleManager;
		}

		public UserManager<IdentityUser> UserManager { get; private set; }
		public RoleManager<IdentityRole> RoleManager { get; private set; }

		[Route("UserCreatedBeacons")]
		public async Task<IHttpActionResult> GetAllUserCreatedBeacons()
		{
			if (!this.User.IsInRole(UserRoles.Admin))
			{
				return this.BadRequest();
			}

            var statusesToBeShipped = await this.Context
                                                .StatusModels
                                                .Include(item => item.UserCreatedBeacon)
			                                    .Include(item => item.UserCreatedBeacon.User)
                                                .Include(item => item.Address)
                                                .Where(item => item.ShipDate == null && item.ReceiveDate == null)
                                                .ToListAsync();

            return this.Ok(statusesToBeShipped);
		}

		[Route("UpdateBeaconStatusShipped/{trackingId}/{id}")]
		public async Task<IHttpActionResult> PostUpdateBeaconStatus(string trackingId, int id)
		{
			if (!this.User.IsInRole(UserRoles.Admin))
			{
				return this.BadRequest();
			}

            var foundStatus = await this.Context.StatusModels.FirstOrDefaultAsync(item => item.Id == id);
            if (foundStatus == null)
            {
                return this.BadRequest("Unable to find status, it doesn't exist anymore.");
            }

            foundStatus.ShipDate = DateTime.Now.ToFileTimeUtc();
            foundStatus.TrackingId = trackingId;

            await this.Context.SaveChangesAsync();

            return this.Ok();
		}

		[Route("DeleteUser/{id}")]
		public async Task<IHttpActionResult> PostDeleteUser(int id)
		{
			if (!this.User.IsInRole(UserRoles.Admin))
			{
				return this.BadRequest();
			}

			var foundUser =
				await this.Context.UserModels.FirstOrDefaultAsync(userInformation => userInformation.Id == id);

			if (foundUser == null)
			{
				return this.Ok();
			}

			this.Context.UserModels.Remove(foundUser);
			await this.Context.SaveChangesAsync();

			return this.Ok();
		}

		[Route("IsAdmin")]
		public bool GetIsAdmin()
		{
			return this.User.IsInRole(UserRoles.Admin);
		}

		[Route("SetPassword")]
		public async Task<IHttpActionResult> PostPassword(PasswordFunctionsModel adminSetPasswordModel)
		{
			if (!this.ModelState.IsValid || !this.User.IsInRole(UserRoles.Admin))
			{
				return this.BadRequest();
			}

			var foundUser = await this.UserManager.FindByNameAsync(adminSetPasswordModel.UserName);

			if (foundUser == null)
			{
				return this.NotFound();
			}
			var removePasswordResult = await this.UserManager.RemovePasswordAsync(foundUser.Id);

			if (!removePasswordResult.Succeeded)
			{
				return this.NotFound();
			}

			var setPasswordResult = await this.UserManager.AddPasswordAsync(foundUser.Id, adminSetPasswordModel.NewPassword);

			if (setPasswordResult.Succeeded)
			{
				return this.Ok();
			}
			return this.NotFound();
		}

		[Route("SetAdmin")]
		public async Task<IHttpActionResult> SetAdmin(PasswordFunctionsModel roleModel)
		{
			if (!ModelState.IsValid || !this.User.IsInRole(UserRoles.Admin))
			{
				return this.BadRequest("Requesting user not an admin.");
			}

			return await this.SetRole(UserRoles.Admin, roleModel.UserName);
		}

		[Route("AllocateBeacons")]
		public async Task<IHttpActionResult> PostAllocateBeacons()
		{
			if (!ModelState.IsValid || !this.User.IsInRole(UserRoles.Admin))
			{
				return this.BadRequest("Requesting user not an admin.");
			}

			// going to do 10,000 at a time. get the current count from total of beaconbroadcastmodel & usercreatedbeacons
			var logicService = new UserCreatedBeaconLogicService(this.Context);
			await logicService.AllocateBeacons(100);

			return this.Ok();
		}

		[Route("BeaconCount")]
		public async Task<IHttpActionResult> GetBeaconCount()
		{
			if (!ModelState.IsValid || !this.User.IsInRole(UserRoles.Admin))
			{
				return this.BadRequest("Requesting user not an admin.");
			}

			var beaconTotal = await this.Context.BeaconBroadcastModels.LongCountAsync();
			var userCreatedTotal = await this.Context.UserCreatedBeaconModels.LongCountAsync();

			return this.Ok(new { beaconTotal, userCreatedTotal });
		}

		private async Task<IHttpActionResult> SetRole(string role, string userName)
		{
			var foundUser = await this.UserManager.FindByNameAsync(userName);

			if (foundUser == null)
			{
				return this.BadRequest("User not found.");
			}

			var roleExists = await this.RoleManager.RoleExistsAsync(role);

			if (!roleExists)
			{
				var identityRole = new IdentityRole(role);
				await this.RoleManager.CreateAsync(identityRole);
			}

			var result = await this.UserManager.AddToRoleAsync(foundUser.Id, role);

			if (result.Succeeded)
			{
				return this.Ok();
			}

			return this.BadRequest("Unable to set to " + role);
		}
	}
}
