using System.Web;
using System.Web.Mvc;

namespace LTSZIN002_CloudWorshop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
