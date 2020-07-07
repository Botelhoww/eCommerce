using eCommerce_Inefavel.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Inefavel.Helpers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class NoDirectAccessAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var canAccess = false;
            var isAdmin = false;

            LoginModel login = new LoginModel();

            //validando se é admin
            if (login.Id == 1)
            {
                isAdmin = true;
            }

            //check de referer
            var referer = filterContext.HttpContext.Request.Headers["Referer"].ToString();

            if (!string.IsNullOrEmpty(referer))
            {
                var rUri = new System.UriBuilder(referer).Uri;
                var req = filterContext.HttpContext.Request;

                if (req.Host.Host == rUri.Host && req.Host.Port == rUri.Port && req.Scheme == rUri.Scheme)
                {
                    isAdmin = true;
                }
            }

            //se n for admin vai redirecionar pra index
            if (!isAdmin)
            {
                filterContext.Result = new RedirectToRouteResult(new
                            RouteValueDictionary(new { controller = "Produtos", action = "Index", area = "" }));
            }

            //if (filterContext.HttpContext.Request.Headers["Referer"].ToString() == null ||
            //        filterContext.HttpContext.Request.Host != filterContext.HttpContext.Request.Headers["Referer"])
            //{
            //    filterContext.Result = new RedirectToRouteResult(new
            //                   RouteValueDictionary(new { controller = "Produtos", action = "Index", area = "" }));
            //}
        }
    }
}
