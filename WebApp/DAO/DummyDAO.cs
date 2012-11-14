using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO.Entities;

namespace DAO
{
    public class DummyDAO : IBourseDAO
    {
        public IEnumerable<Brands> GetBrands()
        {
            List<Brands> brands = new List<Brands>();
           
            brands.Add(new Brands()
            {
                Id = 1,
                Name = "Kiabi"
            });

            brands.Add(new Brands()
            {
                Id = 2,
                Name = "Z"
            });

            return brands;
        }

        public IEnumerable<Articles> GetArticles()
        {
            List<Articles> articles = new List<Articles>();

            articles.Add(new Articles()
            {
                Id = 1,
                Name = "Bavoir"
            });

            articles.Add(new Articles()
            {
                Id = 1,
                Name = "Body"
            });

            return articles;
        }

        public IEnumerable<Details> GetDetails()
        {
            List<Details> details = new List<Details>();

            details.Add(new Details()
            {
                Id = 1,
                Name = "Jaune"
            });

            details.Add(new Details()
            {
                Id = 1,
                Name = "Jaune rayé"
            });

            return details;
        }

        public IEnumerable<Sizes> GetSizes()
        {
            List<Sizes> sizes = new List<Sizes>();

            sizes.Add(new Sizes()
            {
                Id = 1,
                Name = "3 mois"
            });

            sizes.Add(new Sizes()
            {
                Id = 1,
                Name = "6 mois"
            });

            return sizes;
        }

        public IEnumerable<Prices> GetPrices()
        {
            List<Prices> prices = new List<Prices>();

            prices.Add(new Prices()
            {
                Id = 1,
                Name = "2.50"
            });

            prices.Add(new Prices()
            {
                Id = 1,
                Name = "3.50"
            });

            return prices;
        }
    }
}
