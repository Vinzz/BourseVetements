using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO.Entities;

namespace DAO
{
    public interface IBourseDAO
    {
        IEnumerable<Brands> GetBrands();

        void SetBrands(IEnumerable<Brands> brands);

        void InsertNewList(Sell_List newList);
    }
}
