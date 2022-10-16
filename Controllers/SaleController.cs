using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStock.Models.Entity;

namespace MVCStock.Controllers
{
    public class SaleController : Controller
    {
        dbStockEntities db = new dbStockEntities();
        public ActionResult Index()
        {
            var values = db.tblSale.ToList();
            return View(values);
        }
    }
}