using Microsoft.AspNetCore.Mvc.Rendering;

namespace DieUnausstehlichen_Web.Helper
{
    public static class Page
    {
        public static bool IsOnPage(this ViewContext viewContext, string action, string controller)
        {
            return viewContext.RouteData.Values["action"].Equals(action) &&
                   viewContext.RouteData.Values["controller"].Equals(controller);
        }
    }
}