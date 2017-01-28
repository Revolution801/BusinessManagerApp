using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Chaperapp.Web2
{
	public class EmailUserManager : UserManager<IdentityUser>
	{
		public EmailUserManager(IUserStore<IdentityUser> store)
			: base(store)
		{
			this.Users = store;
			this.UserValidator = new UserValidator<IdentityUser>(this)
			{
				AllowOnlyAlphanumericUserNames = false,
			};
		}

		public IUserStore<IdentityUser> Users { get; private set; }
	}
}

