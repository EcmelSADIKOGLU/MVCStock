using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using MVCStock.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace MVCStock.Controllers
{
    public class ProductController : Controller
    {
        dbStockEntities db = new dbStockEntities();
        public ActionResult Index()
        {
            var values = db.tblProduct.ToList();
            return View(values);
        }

        public ActionResult DeleteProduct(int id)
        {
            var p = db.tblProduct.Find(id);
            db.tblProduct.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> values = (from i in db.tblCategory.ToList() select new SelectListItem { Text = i.CategoryName, Value = i.CategoryID.ToString() }).ToList();
            ViewBag.values = values;
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(tblProduct p)
        {
            //if(!ModelState.IsValid)
            //    return View();

            var category = db.tblCategory.Where(m => m.CategoryID == p.tblCategory.CategoryID).FirstOrDefault();
            p.tblCategory = category;
            db.tblProduct.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var p = db.tblProduct.Find(id);

            List<SelectListItem> values = (from i in db.tblCategory.ToList() select new SelectListItem { Text = i.CategoryName, Value = i.CategoryID.ToString() }).ToList();
            ViewBag.values = values;

            return View(p);
        }
        [HttpPost]
        public ActionResult UpdateProduct(tblProduct product)
        {
            var p = db.tblProduct.Find(product.ProductID);
            p.ProductName = product.ProductName;
            p.ProductBrand = product.ProductBrand;
            p.ProductCategory = product.tblCategory.CategoryID;
            p.ProductPrice = product.ProductPrice;
            p.ProductStock = product.ProductStock;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}