using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace werkcoll1.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        public string Index()
        {
            return "at least do dis?";
        }

        public ViewResult Signup ()
        {
            return View();
        }
    }
}