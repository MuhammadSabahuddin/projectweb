﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication26.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Raahi";
            return View();
        }                                          
        public ActionResult Register()
        {
            ViewBag.Title = "Raahi Register";
            return View();
        }
        public ActionResult HomePage()
        {
            ViewBag.Title = "Raahi";
            return View();
        }
        public ActionResult MessagePage()
        {
            ViewBag.Title = "Raahi";
            return View();
        }
        public ActionResult EventsPage()
        {
            ViewBag.Title = "Raahi";
            return View();
        }
        public ActionResult EventsPage2()
        {
            ViewBag.Title = "Raahi";
            return View();
        }
        public ActionResult ProfilePage()
        {
            ViewBag.Title = "Raahi";
            return View();
        }
        public ActionResult AdministratorLogin()
        {
            ViewBag.Title = "Raahi";
            return View();
        }

        public ActionResult Administrator()
        {
            ViewBag.Title = "Raahi";
            return View();
        }
    }
}