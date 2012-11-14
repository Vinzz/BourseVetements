using System;
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
        public IBourseDAO dao { get; set; }

        public HomeController(IBourseDAO dao)
        {
            this.dao = dao;
        }
        public ActionResult Index()
        {
            ViewBag.Location = Properties.Resources.menuListLists;
            return View();
        }
    }
}
