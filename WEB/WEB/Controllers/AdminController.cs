using REALTEST.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace REALTEST.Controllers
{
    public class AdminController : Controller
    {
        ShopEntities dbShop;


        // GET: Admin  public StoreController()
        public AdminController()
        {
            dbShop = new ShopEntities();
        }

        [Authorize]

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult ListProducts()
        {
            var listProducts = dbShop.Products.ToList();
            return View(listProducts);
        }
        [Authorize]
        public ActionResult ListCategories()
        {
            var listCategories = dbShop.Categories.ToList();
            return View(listCategories);
        }

        [Authorize]
        public ActionResult EditProduct(int ProductID)
        {
           
            Products product = dbShop.Products.Find(ProductID);
            if (product == null)
            {
                return HttpNotFound();
            }
            if (ProductID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.CategoryId = new SelectList(dbShop.Categories, "CategoryID", "CategoryName", product.CategoryId);
            return View(product);
        }

        [Authorize]
        [HttpPost, ActionName("EditProduct")]
        [ValidateAntiForgeryToken]
        public ActionResult EditProduct([Bind(Include = "ProductID,ProductName,Price,Quantity,Detail,ProductImage,CategoryId")] Products product)
        {

            if (ModelState.IsValid)
            {
                dbShop.Entry(product).State = EntityState.Modified;
                dbShop.SaveChanges();
                return RedirectToAction("ListProducts");
            }
            ViewBag.CategoryId = new SelectList(dbShop.Categories, "CategoryID", "CategoryName", product.CategoryId);
            return View(product);
        }

        [Authorize]
        public ActionResult DeleteProduct(int ProductID)
        {
            if (ProductID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products product = dbShop.Products.Find(ProductID);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
         
        }

        [HttpPost, ActionName("DeleteProduct")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int ProductID)
        {
            Products product = dbShop.Products.Find(ProductID);
            dbShop.Products.Remove(product);
            dbShop.SaveChanges();
            return RedirectToAction("ListProducts");
        }

        [Authorize]
        public ActionResult CreateProduct()
        {
            ViewBag.CategoryId = new SelectList(dbShop.Categories, "CategoryID", "CategoryName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProduct([Bind(Include = "ProductName,Price,Quantity,Detail,ProductImage,CategoryId")] Products product)
        {
            if (ModelState.IsValid)
            {
                dbShop.Products.Add(product);
                dbShop.SaveChanges();
                return RedirectToAction("ListProducts");
            }

            ViewBag.CategoryId = new SelectList(dbShop.Categories, "CategoryID", "CategoryName", product.CategoryId);
            return View(product);
        }

        [Authorize]
        public ActionResult EditCategory(int CategoryID)
        {
            if (CategoryID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categories categories = dbShop.Categories.Find(CategoryID);
            if (categories == null)
            {
                return HttpNotFound();
            }
            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCategory([Bind(Include = "CategoryID,CategoryName")] Categories categories)
        {
            if (ModelState.IsValid)
            {
                dbShop.Entry(categories).State = EntityState.Modified;
                dbShop.SaveChanges();
                return RedirectToAction("ListCategories");
            }
            return View(categories);
        }

        [Authorize]
        public ActionResult DelelteCategory(int CategoryID)
        {

            if (CategoryID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categories categories = dbShop.Categories.Find(CategoryID);
            if (categories == null)
            {
                return HttpNotFound();
            }
            return View(categories);
        }

        [Authorize]
        [HttpPost, ActionName("DelelteCategory")]
        [ValidateAntiForgeryToken]
        public ActionResult DelelteCate(int CategoryID)
        {
            Categories categories = dbShop.Categories.Find(CategoryID);
            dbShop.Categories.Remove(categories);
            dbShop.SaveChanges();
            return RedirectToAction("ListCategories");
        }

        [Authorize]
        public ActionResult CreateCategory()
        {           
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCategory([Bind(Include = "CategoryID,CategoryName")] Categories categories)
        {
            if (ModelState.IsValid)
            {
                dbShop.Categories.Add(categories);
                dbShop.SaveChanges();
                return RedirectToAction("ListCategories");
            }

            return View(categories);
        }
    }
}






        //public ActionResult login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult login( FormCollection collection)
        //{
        //    //gan gia tri ngui dung
        //    var tendn = collection["username"];
        //    var matkhau = collection["password"];
        //    if (string.IsNullOrEmpty(tendn))
        //    {
        //        ViewData["Loi1"] = "phai nhap ten dang nhap";

        //    }
        //    else if (string.IsNullOrEmpty(matkhau))
        //    {
        //        ViewData["Loi2"] = "phai nhap mat khau";
        //    }
        //    else
        //    {
        //        //Admin ad = db.Admins.SingleOrDefault(n => n.useradmin == tendn && n.passadmin == matkhau);
        //        //if (ad != null)
        //        //{
        //        //    Session["Taikhoanadmin"] = ad;
        //        //    return RedirectToAction("index", "admin");
        //        //}
        //        //else
        //        //    ViewBag.Thongbao = "ten dang nhap hoac mat khau khong dung";
        //    }
        //    ViewBag.Thongbao = "ten dang nhap hoac mat khau khong dung";
        //    return View();
        //}


    


