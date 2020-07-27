using System.Web;
using System.Web.Mvc;

namespace xmldoc_translator
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
