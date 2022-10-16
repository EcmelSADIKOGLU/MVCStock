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
    public class CustomerController : Controller
    {
        dbStockEntities db = new dbStockEntities();
        public ActionResult Index()
        {
            var values = db.tblCustomer.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(tblCustomer p1)
        {
            if(!ModelState.IsValid)
                return View();
            db.tblCustomer.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCustomer(int id)
        {
            var p = db.tblCustomer.Find(id);
            db.tblCustomer.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCustomer(int id)
        {
            var p = db.tblCustomer.Find(id);
            return View(p);
        }
        [HttpPost]
        public ActionResult UpdateCustomer(tblCustomer customer)
        {
            var p = db.tblCustomer.Find(customer.CustomerID);
            p.CustomerName = customer.CustomerName;
            p.CustomerSurname = customer.CustomerSurname;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}