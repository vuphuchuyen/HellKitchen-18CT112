using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodWeb.Areas.ADmin.Controllers
{
    public class HomeadminController : Controller
    {
        // GET: ADmin/Homeadmin
        public ActionResult Index()
        {
            return View();
        }
    }
}