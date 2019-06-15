using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NonFactors.Mvc.Grid;

namespace Sample.MVC5.Grid
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            (MvcGrid.Filters as GridFilters).BooleanTrueOptionText = () => "Ja";
            (MvcGrid.Filters as GridFilters).BooleanFalseOptionText = () => "Nein";
        }
    }
}
