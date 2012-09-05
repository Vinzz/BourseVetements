using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class NewListViewModel
    {
        public string SelectedItemId { get; set; }
        public List<string> brands { get; set; }

        public NewListViewModel()
        {
            brands = new List<string>();
            brands.Add("kiabi");
            brands.Add("toto");
        }
    }
}