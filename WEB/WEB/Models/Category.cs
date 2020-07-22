using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace REALTEST.Models
{
    public class Category
    {
        [DisplayName("Category ID")]
        public int CategoryID { get; set; }

        [DisplayName("Category Name")]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}