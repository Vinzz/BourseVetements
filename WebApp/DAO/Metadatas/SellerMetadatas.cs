using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using DAO.Properties;

namespace DAO.Entities
{
    public class SellerMetadatas
    {
        private SellerMetadatas()
        {
        }

        [Display(Name = "Name", ResourceType = typeof(Resources))]
        public string Name { get; set; }

        [Display(Name = "City", ResourceType = typeof(Resources))]
        public string City { get; set; }

        [Display(Name = "Phone", ResourceType = typeof(Resources))]
        public string Phone { get; set; }

        [Display(Name = "Mail", ResourceType = typeof(Resources))]
        public string Mail { get; set; }
    }
}
