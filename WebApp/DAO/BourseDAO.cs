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
        /// Gets the BrandReferences.
        /// </summary>
        /// <returns>the BrandReferences</returns>
        public IEnumerable<Entities.BrandReferences> GetBrandReferences()
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                return context.BrandReferencesSet.ToList();
            }
        }

        /// <summary>
        /// Gets the articles.
        /// </summary>
        /// <returns>the articles</returns>
        public IEnumerable<ArticleReferences> GetArticles()
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                return context.ArticleReferencesSet.ToList();
            }
        }

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns>the details</returns>
        public IEnumerable<DetailReferences> GetDetails()
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                return context.DetailReferencesSet.ToList();
            }
        }

        /// <summary>
        /// Gets the sizes.
        /// </summary>
        /// <returns>the sizes</returns>
        public IEnumerable<SizeReferences> GetSizes()
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                return context.SizeReferencesSet.ToList();
            }
        }

        /// <summary>
        /// Gets the prices.
        /// </summary>
        /// <returns>the prices</returns>
        public IEnumerable<PriceReferences> GetPrices()
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection(this.ServerURI))
            {
                BourseEntities context = new BourseEntities(connection);

                return context.PriceReferencesSet.ToList();
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

                context.ArticleReferencesSet.AddObject(new ArticleReferences()
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

                context.DetailReferencesSet.AddObject(new DetailReferences()
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

                context.BrandReferencesSet.AddObject(new BrandReferences()
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

                context.SizeReferencesSet.AddObject(new SizeReferences()
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

                context.PriceReferencesSet.AddObject(new PriceReferences()
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