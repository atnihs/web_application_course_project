using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REALTEST.Models
{
    public class ListCategies
    {

        private int categroyID;
        private string categoryName;

        public ListCategies()
        {

        }

        public ListCategies(int CategoryID, string CategoryName)
        {
            categroyID = CategoryID;
            categoryName = CategoryName;
        }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}