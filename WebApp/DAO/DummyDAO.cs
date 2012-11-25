using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO.Entities;

namespace DAO
{
    public class DummyDAO : IBourseDAO
    {
        public string serverURI { get; set; }

        List<Brands> brands = new List<Brands>();
        List<Articles> articles = new List<Articles>();
        List<Details> details = new List<Details>();
        List<Sizes> sizes = new List<Sizes>();
        List<Prices> prices = new List<Prices>();

        public IEnumerable<Brands> GetBrands()
        {
            if (brands.Count == 0)
            {
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
            }
            return brands;
        }

        public IEnumerable<Articles> GetArticles()
        {
            if (articles.Count == 0)
            {
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
            }
            return articles;
        }

        public IEnumerable<Details> GetDetails()
        {
            if (details.Count == 0)
            {
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
            }
            return details;
        }

        public IEnumerable<Sizes> GetSizes()
        {
            if (sizes.Count == 0)
            {
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
            }
            return sizes;
        }

        public IEnumerable<Prices> GetPrices()
        {
            if (prices.Count == 0)
            {
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
            }
            return prices;
        }

        public void AddArticle(string newArticle)
        {
            articles.Add(new Articles()
            {
                Id = 1,
                Name = newArticle
            });
        }

        public void AddDetail(string newDetail)
        {
            details.Add(new Details()
            {
                Id = 1,
                Name = newDetail
            });
        }

        public void AddBrand(string newBrand)
        {
            brands.Add(new Brands()
            {
                Id = 1,
                Name = newBrand
            });
        }

        public void AddSize(string newSize)
        {
            sizes.Add(new Sizes()
            {
                Id = 1,
                Name = newSize
            });
        }

        public void AddPrice(string newPrice)
        {
            prices.Add(new Prices()
            {
                Id = 1,
                Name = newPrice
            });
        }
    }
}
