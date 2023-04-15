using System.Web;
using System.Web.Mvc;

namespace LoginWithGoogle_UsingIdentity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
