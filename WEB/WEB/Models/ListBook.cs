using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace REALTEST.Models
{
    public class ListBook
    {

        private int productID;
        private string productName;
        private float price;
        private int quantity;
        private string detail;
        private string productImage;
        private int productCategory;

        public ListBook()
        {

        }

        public ListBook(int ProductID, string ProductName, float Price, int Quantity, string Detail, string ProductImage, int ProductCategory)
        {
            productID = ProductID;
            productName = ProductName;
            price = Price;
            quantity = Quantity;
            detail = Detail;
            productImage = ProductImage;
            productCategory = ProductCategory;
        }

        [DisplayName("Product ID")]
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
        public int ProductCategory { get; set; }
    }
}