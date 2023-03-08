using System.Web;
using System.Web.Mvc;

namespace _2080600734_VuXuanDoanTrang_THW_Buoi2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
