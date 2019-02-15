using System.Web;
using System.Web.Mvc;

namespace SparksPlumbingAndHeating
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters( GlobalFilterCollection filters )
		{
			filters.Add( new HandleErrorAttribute() );
		}
	}
}
