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

        IEnumerable<ArticleReferences> GetArticles();

        IEnumerable<DetailReferences> GetDetails();

        IEnumerable<BrandReferences> GetBrandReferences();

        IEnumerable<SizeReferences> GetSizes();

        IEnumerable<PriceReferences> GetPrices();

        void AddArticle(string newArticle);

        void AddDetail(string newDetail);

        void AddBrand(string newBrand);

        void AddSize(string newSize);

        void AddPrice(string newPrice);

        void SaveList(Sell_List sell_List);
    }
}