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
using WebApp.Properties;

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
            ViewBag.Title = Properties.Resources.titleEditList;
            ViewBag.Location = Properties.Resources.menuEditList;
            NewListViewModel model = new NewListViewModel();

            return View("List", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(NewListViewModel updatedModel, string submitButtonValue)
        {
            if (ModelState.IsValid)
            {
                if (submitButtonValue == Resources.btnAddArticle)
                {
                    return AddArticle(updatedModel);
                }
                else
                {
                    if (submitButtonValue == Resources.btnSaveList)
                    {
                        return SaveList(updatedModel);
                    }
                }
                throw new Exception("Unknown button name");
            }
            else
            {
                return View("List", updatedModel);
            }
        }

        private ActionResult SaveList(NewListViewModel updatedModel)
        {
            this.dao.SaveList(updatedModel.ListBO);

            ResetCurrentArticle(ref updatedModel);

            return View("List", updatedModel);
        }

        private ActionResult AddArticle(NewListViewModel updatedModel)
        {
            if (!string.IsNullOrEmpty(updatedModel.SelectedArticleId) && this.dao.GetArticles().Where(x => x.Name == updatedModel.SelectedArticleId).Count() == 0)
            {
                this.dao.AddArticle(updatedModel.SelectedArticleId);
            }

            if (!string.IsNullOrEmpty(updatedModel.SelectedDetailColorId) && this.dao.GetDetails().Where(x => x.Name == updatedModel.SelectedDetailColorId).Count() == 0)
            {
                this.dao.AddDetail(updatedModel.SelectedDetailColorId);
            }

            if (!string.IsNullOrEmpty(updatedModel.SelectedBrandId) && this.dao.GetBrandReferences().Where(x => x.Name == updatedModel.SelectedBrandId).Count() == 0)
            {
                this.dao.AddBrand(updatedModel.SelectedBrandId);
            }

            if (!string.IsNullOrEmpty(updatedModel.SelectedSizeId) && this.dao.GetSizes().Where(x => x.Name == updatedModel.SelectedSizeId).Count() == 0)
            {
                this.dao.AddSize(updatedModel.SelectedSizeId);
            }

            if (!string.IsNullOrEmpty(updatedModel.SelectedPriceId) && this.dao.GetPrices().Where(x => x.Name == updatedModel.SelectedPriceId).Count() == 0)
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

            // Save the current list
            this.dao.SaveList(updatedModel.ListBO);

            // Reset
            ResetCurrentArticle(ref updatedModel);

            return View("List", updatedModel);
        }

        private static void ResetCurrentArticle(ref NewListViewModel updatedModel)
        {
            updatedModel.SelectedArticleId = string.Empty;
            updatedModel.SelectedDetailColorId = string.Empty;
            updatedModel.SelectedBrandId = string.Empty;
            updatedModel.SelectedPriceId = string.Empty;
            updatedModel.SelectedSizeId = string.Empty;
            updatedModel.isAToy = false;
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
        public ActionResult AutocompleteBrandReferences(string term)
        {
            var ans = this.dao.GetBrandReferences().Where(x => x.Name.ToUpper().StartsWith(term.ToUpper())).Select(x => x.Name);
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