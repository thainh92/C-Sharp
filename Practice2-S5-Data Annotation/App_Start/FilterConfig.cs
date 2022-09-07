using System.Web;
using System.Web.Mvc;

namespace Practice2_S5_Data_Annotation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
