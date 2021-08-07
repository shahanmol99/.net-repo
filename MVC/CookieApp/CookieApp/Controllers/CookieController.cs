using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookieApp.Controllers
{
    public class CookieController : Controller
    {
        public ActionResult SetCookie()
        {
            if (Request.Cookies["color"] == null)
            {
                HttpCookie cookie = new HttpCookie("color", "Red");
                cookie.Expires = DateTime.Now.AddDays(7.0);
                Session["expires"] = cookie.Expires.ToString();
                Response.Cookies.Add(cookie);
                ViewBag.Message = "Cookie Set Successfully";
                return View();
            }

            ViewBag.Message = "Cookie Is Already Set";
            return View();

        }

        public ActionResult GetCookie()
        {
            if(Request.Cookies["color"]==null)
            {
                return Content("No Cookie Found");
            }

            ViewBag.ExpiryDate = Request.Cookies["color"].Expires;
            return View();
        }
    }
}