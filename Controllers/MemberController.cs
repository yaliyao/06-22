using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_0622_login1.Models;

namespace test_0622_login1.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Login()
        {
            //ViewBag.id = "";
            //ViewBag.password = "";
            Member obj = new Models.Member( ){
                id = "",
                password =""};     
            return View(obj);
        }
        [HttpPost]
        //public ActionResult Login(string id, string password)
        public ActionResult Login(Member obj) {
            //public ActionResult Login(string id, string password){
            //int errorCount = 0;
            //if (string.IsNullOrEmpty(id)) {
            //    errorCount++;
            //}

            //if (string.IsNullOrEmpty(password)) {
            //    errorCount++;
            //}

            //if (errorCount == 0) {
            //    Session["userId"] = id;
            //    return RedirectToAction("Index", "Home");
            //

            //ViewBag.id = id;
            //ViewBag.password = password;}

            if (obj.validata()) {
                Session["userId"] = obj.id;
                return RedirectToAction("Index", "Home");

            }

            return View(obj);
        }

        public ActionResult Signout() {
            Session["userId"] = "guest";

            return RedirectToAction("Index","Home");
        }
    }
}