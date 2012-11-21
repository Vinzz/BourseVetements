using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.EntityClient;
using DAO.Entities;

namespace DAO
{
    public class BourseDAO : IBourseDAO
    {
        public IEnumerable<Entities.Brands> GetBrands()
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection())
            {
                BourseEntities context = new BourseEntities(connection);

                return context.BrandsSet;
            }
        }

        public IEnumerable<Articles> GetArticles()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Details> GetDetails()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sizes> GetSizes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prices> GetPrices()
        {
            throw new NotImplementedException();
        }


        public void AddArticle(string newArticle)
        {
            throw new NotImplementedException();
        }

        public void AddDetail(string newDetail)
        {
            throw new NotImplementedException();
        }

        public void AddBrand(string newBrand)
        {
            throw new NotImplementedException();
        }

        public void AddSize(string newSize)
        {
            throw new NotImplementedException();
        }

        public void AddPrice(string newPrice)
        {
            throw new NotImplementedException();
        }
    }
}
