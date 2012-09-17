﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using DAO;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(IBourseDAO dao)
        {
            ViewBag.Message = "Page principale";
            NewListViewModel model = new NewListViewModel();

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
