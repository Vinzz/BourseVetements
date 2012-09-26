using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO.Entities;

namespace DAO
{
    public class DummyDAO : IBourseDAO
    {
        private List<Brands> brands = new List<Brands>();

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
                    Id = 1,
                    Name = "Z"
                });
            }

            return brands;
        }

        public void SetBrands(IEnumerable<Brands> brands)
        {
            throw new NotImplementedException();
        }

        public void InsertNewList(Sell_List newList)
        {
            throw new NotImplementedException();
        }
    }
}
