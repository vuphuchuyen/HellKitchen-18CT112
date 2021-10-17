﻿using System.Web.Mvc;

namespace FoodWeb.Areas.ADmin
{
    public class ADminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ADmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ADmin_default",
                "ADmin/{controller}/{action}/{id}",
                new { action = "Index",controller="Home" ,id = UrlParameter.Optional }
            );
        }
    }
}