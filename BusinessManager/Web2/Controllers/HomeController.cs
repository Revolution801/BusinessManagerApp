using System.Web.Mvc;

namespace Chaperapp.Web2.Controllers
{
	[Authorize]
	public class HomeController : Controller
	{
		[AllowAnonymous]
		public ActionResult Index()
		{
			return this.View();
		}

		[AllowAnonymous]
		public ActionResult Login()
		{
			return this.PartialView();
		}

		[AllowAnonymous]
		public ActionResult Register()
		{
			return this.PartialView();
		}

		[AllowAnonymous]
		public ActionResult Home()
		{
			return this.PartialView();
		}

		public ActionResult Admin()
		{
			return this.PartialView();
		}

		public ActionResult Allowance()
		{
			return this.PartialView();
		}

		public ActionResult Address()
		{
			return this.PartialView();
		}

		public ActionResult PurchaseAddress()
		{
			return this.PartialView();
		}

		public ActionResult PurchaseNames()
		{
			return this.PartialView();
		}

		public ActionResult PurchaseVerify()
		{
			return this.PartialView();
		}

		public ActionResult PurchaseFinal()
		{
			return this.PartialView();
		}

		public ActionResult PurchaseFinalError()
		{
			return this.PartialView();
		}

		public ActionResult ManageUserCreatedBeacons()
		{
			return this.PartialView();
		}
	}
}

