using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult Welcome1()
        {
            return View();
        }

        public ActionResult Welcome2()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<html>");
            sb.Append("\n");
            sb.Append("<body>");
            sb.Append("\n");

            if (Request.QueryString.AllKeys.Contains("developer"))
            {
                sb.Append("\t<h2>Welcome " + Request.QueryString["developer"] + "</h2>");
                sb.Append("\n");
            }
            else
            {
                sb.Append("\t<h2>Welcome Nobody</h2>");
                sb.Append("\n");
            }

            sb.Append("</body>");
            sb.Append("\n");
            sb.Append("</html>");

            return Content(sb.ToString());
        }

        public ActionResult Welcome3()
        {
            if(Request.QueryString.AllKeys.Contains("developer"))
            {
                return Json(new { name = Request.QueryString["developer"], Company = "Swabhav" }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { name = "Anmol", Company = "Swabhav" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult login()
        {
            return View();
        }

        public ActionResult auth(string username, string password)
        {
            return View();
        }
    }
}