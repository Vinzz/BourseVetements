
namespace BourseDAOTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;
    using DAO;
    using System.Data.EntityClient;
    using DAO.Entities;

    [TestFixture]
    public class TestDBConnection
    {
        // [Test]
        public void GetSomeBrands()
        {
            using (EntityConnection connection = DBConnection.GetEntityConnection())
            {
                BourseEntities context = new BourseEntities(connection);

                Assert.IsTrue(context.BrandsSet.Count() > 0);
            }
        }
    }
}
