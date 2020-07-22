using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace REALTEST.Models
{
    public class Product
    {
        [DisplayName ("Product ID")]
        public int ProductID { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Price")]
        public float Price { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [DisplayName("Detail")]
        public string Detail { get; set; }

        [DisplayName("Product Image")]
        public string ProductImage { get; set; }

        [DisplayName("Category Id")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

       
    }
}