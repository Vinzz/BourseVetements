namespace DAO.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel.DataAnnotations;
    using DAO.Properties;

    public class ArticleMetadatas
    {
        private ArticleMetadatas()
        {
        }

        [Display(Name = "ArticleName", ResourceType = typeof(Resources))]
        public string Name { get; set; }

        [Display(Name = "ArticleDetails", ResourceType = typeof(Resources))]
        public string Details { get; set; }

        [Display(Name = "ArticleBrand", ResourceType = typeof(Resources))]
        public string Brand { get; set; }

        [Display(Name = "ArticleSize", ResourceType = typeof(Resources))]
        public string Size { get; set; }

        [Display(Name = "ArticlePrice", ResourceType = typeof(Resources))]
        public double Price { get; set; }

        [Display(Name = "ArticleisToy", ResourceType = typeof(Resources))]
        public bool isToy { get; set; }
    }
}
