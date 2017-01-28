using System.Web.Http;
using Chaperapp.DataContext;
using Roylance.Common;

namespace Chaperapp.Web2.Controllers
{
	public class BaseApiContextController : ApiController
	{
		public BaseApiContextController()
			: this(new ChaperappContext())
		{
		}

		public BaseApiContextController(ChaperappContext context)
		{
			context.CheckIfNull(nameof(context));
			this.Context = context;
		}

		protected ChaperappContext Context { get; private set; }

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Context.Dispose();
			}

			base.Dispose(disposing);
		}
	}
}
