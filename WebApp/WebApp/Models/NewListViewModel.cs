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
        public IEnumerable<Articles> Articles { get; set; }

        [Display(Name = "Details", ResourceType = typeof(Resources))]
        public string SelectedDetailColorId { get; set; }
        public IEnumerable<Details> DetailColor { get; set; }

        [Display(Name = "Brand", ResourceType = typeof(Resources))]
        public string SelectedBrandId { get; set; }
        public IEnumerable<Brands> Brands { get; set; }

        [Display(Name = "Size", ResourceType = typeof(Resources))]
        public string SelectedSizeId { get; set; }
        public IEnumerable<Sizes> Sizes { get; set; }

        [Display(Name = "Price", ResourceType = typeof(Resources))]
        [Required]
        public string SelectedPriceId { get; set; }
        public IEnumerable<Prices> Prices { get; set; }

        [Display(Name = "Toy", ResourceType = typeof(Resources))]
        public bool isAToy { get; set; }
    }
}