﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplatePage.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Career()
        {
            return View();
        }
    }
}