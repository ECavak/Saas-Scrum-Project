using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PropTabTabIK.WebUI.ActionFilters
{
    public class CustomExceptionFilter : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.Result = new ViewResult()
            {
                StatusCode = (int)HttpStatusCode.BadRequest,
                ViewName = "Hata"
            };
            context.ExceptionHandled = true;
        }
    }
}
