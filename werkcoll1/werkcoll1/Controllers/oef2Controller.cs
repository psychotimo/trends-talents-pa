using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace werkcoll1.Controllers
{
    public class oef2Controller : Controller
    {
      

        // GET: oef2
        public ActionResult session(object sessie)
        {
            sessie = System.Web.HttpContext.Current.Application["Sessies"];
            return View(sessie);
        }

    }
}