using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REALTEST.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        ShopEntities dbShop;

        public StoreController()
        {
            dbShop = new ShopEntities();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Shop()
        {
            var listProducts = dbShop.Products.ToList();
            return View(listProducts);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Single(int id)
        {
            var product = dbShop.Products.Find(id);

            return View(product);
        }
        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult loi404()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }


    }

    
}