﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult qwer()
        {
            ViewBag.Message = "gln";

            return View();
        }
        public ActionResult add() {
            return View();
        }
        public ActionResult Shuai1() {
            return View();
        }
        public ActionResult adds() {
            return View();
        }
    }
}