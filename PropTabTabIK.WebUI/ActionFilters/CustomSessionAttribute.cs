
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace PropTabTabIK.WebUI.ActionFilters
{

    public class CustomSessionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var ctx = context.HttpContext;
            if (ctx.Session.GetString("Name") == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "Index", controller = "Home" }));
            }
            base.OnActionExecuting(context);
        }
    }
}


