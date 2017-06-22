using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test_0622_login1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Member() {
            if (Session["userId"] == "guest") {
                return RedirectToAction("Login", "Member");
            }
            return View();
        }
    }
}