using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO.Entities;

namespace DAO
{
    public interface IBourseDAO
    {
        string ServerURI { get; set; }

        IEnumerable<Articles> GetArticles();
        IEnumerable<Details> GetDetails();
        IEnumerable<Brands> GetBrands();
        IEnumerable<Sizes> GetSizes();
        IEnumerable<Prices> GetPrices();

        void AddArticle(string newArticle);

        void AddDetail(string newDetail);

        void AddBrand(string newBrand);

        void AddSize(string newSize);

        void AddPrice(string newPrice);
    }
}
