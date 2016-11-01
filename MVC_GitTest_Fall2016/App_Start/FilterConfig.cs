using System.Web;
using System.Web.Mvc;

namespace MVC_GitTest_Fall2016
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
