// --------------------------------------------------------------------------------------------
// <copyright file="DummyDAO.cs" company="Yocto Projects">
// 2012. Distributed under the GPL.
// </copyright>
// --------------------------------------------------------------------------------------------
namespace DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using DAO.Entities;

    /// <summary>
    /// Dummy not connected DAO
    /// </summary>
    public class DummyDAO : IBourseDAO
    {
        /// <summary>
        /// Gets or sets the server URI.
        /// </summary>
        /// <value>
        /// The server URI.
        /// </value>
        public string ServerURI { get; set; }

        /// <summary>
        /// The brands
        /// </summary>
        private List<Brands> brands = new List<Brands>();

        /// <summary>
        /// The articles
        /// </summary>
        private List<Articles> articles = new List<Articles>();

        /// <summary>
        /// The details
        /// </summary>
        private List<Details> details = new List<Details>();

        /// <summary>
        /// The sizes
        /// </summary>
        private List<Sizes> sizes = new List<Sizes>();

        /// <summary>
        /// The prices
        /// </summary>
        private List<Prices> prices = new List<Prices>();

        /// <summary>
        /// Gets the brands.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the articles.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the sizes.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the prices.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Adds the article.
        /// </summary>
        /// <param name="newArticle">The new article.</param>
        public void AddArticle(string newArticle)
        {
            articles.Add(new Articles()
            {
                Id = 1,
                Name = newArticle
            });
        }

        /// <summary>
        /// Adds the detail.
        /// </summary>
        /// <param name="newDetail">The new detail.</param>
        public void AddDetail(string newDetail)
        {
            details.Add(new Details()
            {
                Id = 1,
                Name = newDetail
            });
        }

        /// <summary>
        /// Adds the brand.
        /// </summary>
        /// <param name="newBrand">The new brand.</param>
        public void AddBrand(string newBrand)
        {
            brands.Add(new Brands()
            {
                Id = 1,
                Name = newBrand
            });
        }

        /// <summary>
        /// Adds the size.
        /// </summary>
        /// <param name="newSize">The new size.</param>
        public void AddSize(string newSize)
        {
            sizes.Add(new Sizes()
            {
                Id = 1,
                Name = newSize
            });
        }

        /// <summary>
        /// Adds the price.
        /// </summary>
        /// <param name="newPrice">The new price.</param>
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