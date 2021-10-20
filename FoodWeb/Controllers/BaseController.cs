﻿using FoodWeb.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FoodWeb.Controllers
{
    public class BaseController : Controller
    {
        // GET: ADmin/Base
        // Kiểm tra session login
       protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (UserLogin)Session[Commonstants.USER_SESSION];
            if(session == null )
            {
                filterContext.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new { Controller = "Users", action = "Index" }));
            }
            base.OnActionExecuting(filterContext);
            
        }
    }
}