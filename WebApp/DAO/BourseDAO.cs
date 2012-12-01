// --------------------------------------------------------------------------------------------
// <copyright file="BourseDAO.cs" company="Yocto Projects">
// 2012. Distributed under the GPL.
// </copyright>
// --------------------------------------------------------------------------------------------
namespace DAO
{
    using System.Collections.Generic;
    using System.Data.EntityClient;
    using System.Linq;
    using DAO.Entities;

    /// <summary>
    /// Entity framework DAO
    /// </summary>
    public class BourseDAO : IBourseDAO
    {
        /// <summary>
        /// Gets or sets the server URI.
        /// </summary>
        /// <value>
        /// The server URI.
        /// </value>
        public string ServerURI { get; set; }

        /// <summary>
        /// Gets the brands.
        /// </summary>
        /// <returns>the brands</returns>
        public IEnumerable<Entities.Brands> GetBrands()
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                return context.BrandsSet.ToList();
            }
        }

        /// <summary>
        /// Gets the articles.
        /// </summary>
        /// <returns>the articles</returns>
        public IEnumerable<Articles> GetArticles()
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                return context.ArticlesSet.ToList();
            }
        }

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns>the details</returns>
        public IEnumerable<Details> GetDetails()
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                return context.DetailsSet.ToList();
            }
        }

        /// <summary>
        /// Gets the sizes.
        /// </summary>
        /// <returns>the sizes</returns>
        public IEnumerable<Sizes> GetSizes()
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                return context.SizesSet.ToList();
            }
        }

        /// <summary>
        /// Gets the prices.
        /// </summary>
        /// <returns>the prices</returns>
        public IEnumerable<Prices> GetPrices()
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                return context.PricesSet.ToList();
            }
        }

        /// <summary>
        /// Adds the article.
        /// </summary>
        /// <param name="newArticle">The new article.</param>
        public void AddArticle(string newArticle)
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                context.ArticlesSet.AddObject(new Articles()
                    {
                        Name = newArticle
                    });

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Adds the detail.
        /// </summary>
        /// <param name="newDetail">The new detail.</param>
        public void AddDetail(string newDetail)
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                context.DetailsSet.AddObject(new Details()
                {
                    Name = newDetail
                });

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Adds the brand.
        /// </summary>
        /// <param name="newBrand">The new brand.</param>
        public void AddBrand(string newBrand)
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                context.BrandsSet.AddObject(new Brands()
                {
                    Name = newBrand
                });

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Adds the size.
        /// </summary>
        /// <param name="newSize">The new size.</param>
        public void AddSize(string newSize)
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                context.SizesSet.AddObject(new Sizes()
                {
                    Name = newSize
                });

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Adds the price.
        /// </summary>
        /// <param name="newPrice">The new price.</param>
        public void AddPrice(string newPrice)
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                context.PricesSet.AddObject(new Prices()
                {
                    Name = newPrice
                });

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Saves the list.
        /// </summary>
        /// <param name="sell_List">The sell_ list.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void SaveList(Sell_List sell_List)
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                context.Sell_ListSet.AddObject(sell_List);

                context.SaveChanges();
            }
        }
    }
}