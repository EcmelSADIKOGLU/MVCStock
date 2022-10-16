using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStock.Models.Entity;
using PagedList;
using PagedList.Mvc;


namespace MVCStock.Controllers
{
    public class CategoryController : Controller
    {
        dbStockEntities db = new dbStockEntities();
        public ActionResult Index()
        {
            var values = db.tblCategory.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(tblCategory p1)
        {
            if(!ModelState.IsValid)
                return View();
            db.tblCategory.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var p = db.tblCategory.Find(id);
            db.tblCategory.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var p = db.tblCategory.Find(id);
            return View(p);
        }
        [HttpPost]
        public ActionResult UpdateCategory(tblCategory category)
        {
            var p = db.tblCategory.Find(category.CategoryID);
            p.CategoryName = category.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}