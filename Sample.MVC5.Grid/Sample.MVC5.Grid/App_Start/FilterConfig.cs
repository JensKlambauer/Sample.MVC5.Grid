using System.Web;
using System.Web.Mvc;

namespace Sample.MVC5.Grid
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
