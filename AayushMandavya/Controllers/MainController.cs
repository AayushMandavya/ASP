using AayushMandavya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AayushMandavya.Controllers
{
    public class MainController : Controller
    {
        mainEntities db = new mainEntities();

        // GET: Main
        public ActionResult mainview()
        {
            List<employee> data = db.employees.ToList();

            return View(data);
        }
        public ActionResult create()
        {
        

            return View();
        }

        public ActionResult SaveData(employee employee)
        {
         
            db.employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("mainview");
        }
    }

}