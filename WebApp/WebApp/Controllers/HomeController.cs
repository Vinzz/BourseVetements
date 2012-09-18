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
            NewListViewModel model = new NewListViewModel();

            model.brands = dao.GetBrands();

            ViewBag.Message = string.Format("number of brands in DB: {0}", model.brands.Count());

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
