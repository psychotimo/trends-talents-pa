using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_stack.Controllers
{
    public class oef2we1Controller : Controller
    {
        // GET: oef2we1
        public ActionResult Index()
        {
            object test = System.Web.HttpContext.Current.Application["Sessies"];
           int sessie= Convert.ToInt32( System.Web.HttpContext.Current.Session["Sessies"]);
            return View();
        }
    }
}