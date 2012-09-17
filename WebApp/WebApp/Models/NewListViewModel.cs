using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAO.Entities;
using DAO;

namespace WebApp.Models
{
    public class NewListViewModel
    {
        public string SelectedItemId { get; set; }
        public IEnumerable<Brands> brands { get; set; }
    }
}