using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;
using WebApp.Models;
using Lib.Web.Mvc;

namespace WebApp.Controllers
{
    public class ListController : Controller
    {
        public IBourseDAO dao { get; set; }

        public ListController(IBourseDAO dao)
        {
            this.dao = dao;
        }

        public ActionResult Index()
        {
            ViewBag.Location = Properties.Resources.menuEditList;

            NewListViewModel model = new NewListViewModel();

            return View("List", model);
        }

        [NoCache]
        public ActionResult AutocompleteArticle(string term)
        {
            var ans = this.dao.GetArticles().Where(x => x.Name.ToUpper().StartsWith(term.ToUpper())).Select(x => x.Name);
            return Json(ans.ToArray(), JsonRequestBehavior.AllowGet);
        }

        [NoCache]
        public ActionResult AutocompleteDetails(string term)
        {
            var ans = this.dao.GetDetails().Where(x => x.Name.ToUpper().StartsWith(term.ToUpper())).Select(x => x.Name);
            return Json(ans.ToArray(), JsonRequestBehavior.AllowGet);
        }

        [NoCache]
        public ActionResult AutocompleteBrands(string term)
        {
            var ans = this.dao.GetBrands().Where(x => x.Name.ToUpper().StartsWith(term.ToUpper())).Select(x => x.Name);
            return Json(ans.ToArray(), JsonRequestBehavior.AllowGet);
        }

        [NoCache]
        public ActionResult AutocompleteSizes(string term)
        {
            var ans = this.dao.GetSizes().Where(x => x.Name.ToUpper().StartsWith(term.ToUpper())).Select(x => x.Name);
            return Json(ans.ToArray(), JsonRequestBehavior.AllowGet);
        }

        [NoCache]
        public ActionResult AutocompletePrices(string term)
        {
            var ans = this.dao.GetPrices().Where(x => x.Name.ToUpper().StartsWith(term.ToUpper())).Select(x => x.Name);
            return Json(ans.ToArray(), JsonRequestBehavior.AllowGet);
        }   
    }
}
