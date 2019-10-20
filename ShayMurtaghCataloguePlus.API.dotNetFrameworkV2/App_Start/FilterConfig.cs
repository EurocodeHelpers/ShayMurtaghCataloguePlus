using System.Web;
using System.Web.Mvc;

namespace ShayMurtaghCataloguePlus.API.dotNetFrameworkV2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
