﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Guestbook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Color()
            { 
                return View();
            }

        public ActionResult Map()
            { 
                return View();
            }

        public ActionResult About()
        {
            ViewBag.Message = "Valt hier niet veel te zeggen eigenlijk.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Waarom zou je contact willen opnemen?";

            return View();
        }
    }
}