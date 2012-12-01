using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAO.Entities;
using DAO;
using System.ComponentModel.DataAnnotations;
using WebApp.Properties;
using System.Data.Objects.DataClasses;

namespace WebApp.Models
{
    public class NewListViewModel
    {
        public NewListViewModel()
        {
            ListBO = new Sell_List();
        }

        public Sell_List ListBO { get; set; }

        [Display(Name = "Article", ResourceType = typeof(Resources))]
        [Required]
        public string SelectedArticleId { get; set; }
        public IEnumerable<ArticleReferences> Articles { get; set; }

        [Display(Name = "Details", ResourceType = typeof(Resources))]
        public string SelectedDetailColorId { get; set; }
        public IEnumerable<DetailReferences> DetailColor { get; set; }

        [Display(Name = "Brand", ResourceType = typeof(Resources))]
        public string SelectedBrandId { get; set; }
        public IEnumerable<BrandReferences> BrandReferences { get; set; }

        [Display(Name = "Size", ResourceType = typeof(Resources))]
        public string SelectedSizeId { get; set; }
        public IEnumerable<SizeReferences> Sizes { get; set; }

        [Display(Name = "Price", ResourceType = typeof(Resources))]
        [Required]
        public string SelectedPriceId { get; set; }
        public IEnumerable<PriceReferences> Prices { get; set; }

        [Display(Name = "Toy", ResourceType = typeof(Resources))]
        public bool isAToy { get; set; }
    }
}