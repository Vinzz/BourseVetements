

namespace DAO.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel.DataAnnotations;
    using DAO.Properties;

    public class Sell_ListMetadatas
    {
        private Sell_ListMetadatas()
        {
        }

        [Display(Name = "NumberClothes", ResourceType = typeof(Resources))]
        public int NumberClothes { get; set; }

         [Display(Name = "NumberToys", ResourceType = typeof(Resources))]
        public int NumberToys { get; set; }
    }
}
