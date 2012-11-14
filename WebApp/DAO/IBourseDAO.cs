using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO.Entities;

namespace DAO
{
    public interface IBourseDAO
    {
        IEnumerable<Articles> GetArticles();
        IEnumerable<Details> GetDetails();
        IEnumerable<Brands> GetBrands();
        IEnumerable<Sizes> GetSizes();
        IEnumerable<Prices> GetPrices();
    }
}
