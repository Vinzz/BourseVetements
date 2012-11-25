using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;
using DAO.Entities;
using Lib.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ListController : Controller
    {
        public IBourseDAO dao { get; set; }

        public ListController(IBourseDAO dao)
        {
            this.dao = dao;
            this.dao.ServerURI = ConfigurationManager.AppSettings["SQLSERVER_URI"];
        }

        public ActionResult Index()
        {
            ViewBag.Location = Properties.Resources.menuEditList;
            NewListViewModel model = new NewListViewModel();

            return View("List", model);
        }

        [HttpPost]
        public ActionResult AddArticle(NewListViewModel updatedModel)
        {
            if (this.dao.GetArticles().Where(x => x.Name == updatedModel.SelectedArticleId).Count() == 0)
            {
                this.dao.AddArticle(updatedModel.SelectedArticleId);
            }

            if (this.dao.GetDetails().Where(x => x.Name == updatedModel.SelectedDetailColorId).Count() == 0)
            {
                this.dao.AddDetail(updatedModel.SelectedArticleId);
            }

            if (this.dao.GetBrands().Where(x => x.Name == updatedModel.SelectedBrandId).Count() == 0)
            {
                this.dao.AddBrand(updatedModel.SelectedArticleId);
            }

            if (this.dao.GetSizes().Where(x => x.Name == updatedModel.SelectedPriceId).Count() == 0)
            {
                this.dao.AddSize(updatedModel.SelectedSizeId);
            }

            if (this.dao.GetPrices().Where(x => x.Name == updatedModel.SelectedSizeId).Count() == 0)
            {
                this.dao.AddPrice(updatedModel.SelectedPriceId);
            }

            updatedModel.ListBO.Article.Add(new Article()
            {
                Name = updatedModel.SelectedArticleId,
                Details = updatedModel.SelectedDetailColorId,
                Brand = updatedModel.SelectedBrandId,
                Price = double.Parse(updatedModel.SelectedPriceId.Replace('.', ',')),
                Size = updatedModel.SelectedSizeId,
                isToy = updatedModel.isAToy
            });

            // Reset
            updatedModel.SelectedArticleId = string.Empty;
            updatedModel.SelectedDetailColorId = string.Empty;
            updatedModel.SelectedBrandId = string.Empty;
            updatedModel.SelectedPriceId = string.Empty;
            updatedModel.SelectedSizeId = string.Empty;
            updatedModel.isAToy = false;

            return View("List", updatedModel);
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