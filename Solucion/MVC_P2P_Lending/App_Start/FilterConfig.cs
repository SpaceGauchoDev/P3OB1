using System.Web;
using System.Web.Mvc;

namespace MVC_P2P_Lending
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
