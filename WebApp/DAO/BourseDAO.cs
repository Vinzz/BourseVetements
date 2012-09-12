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

        public void SetBrands(IEnumerable<Entities.Brands> brands)
        {
            throw new NotImplementedException();
        }

        public void InsertNewList(Entities.Sell_List newList)
        {
            throw new NotImplementedException();
        }
    }
}
