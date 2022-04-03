using AayushMandavya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AayushMandavya.Controllers
{
    public class main2Controller : Controller
    {
        mainEntities db = new mainEntities();
        // GET: main2
        public ActionResult mainview2()
        {
            List<book> data = db.books.ToList();
            return View(data);
        }
        public ActionResult create2()
        {
            return View();  
        }
        public ActionResult SaveData(book book)
        {

            db.books.Add(book);
            db.SaveChanges();
            return RedirectToAction("mainview2");
        }
    }
}