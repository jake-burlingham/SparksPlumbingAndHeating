using Ninject;
using Ninject.Web.Common.WebHost;
using SparksPlumbingAndHeating;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Sparks.PlumbingAndHeating.UI
{
	public class MvcApplication : NinjectHttpApplication
	{
		protected override void OnApplicationStarted()
		{
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters( GlobalFilters.Filters );
			RouteConfig.RegisterRoutes( RouteTable.Routes );
			BundleConfig.RegisterBundles( BundleTable.Bundles );
		}

		protected override IKernel CreateKernel()
		{
			var kernel = new StandardKernel();

			return kernel;
		}
	}
}
