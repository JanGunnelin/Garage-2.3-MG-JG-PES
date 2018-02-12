using System.Web;
using System.Web.Mvc;

namespace Garage_2_3_MG_JG_PES
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
