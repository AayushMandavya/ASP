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
        public ActionResult Edit(int id)
        {
            employee employee= db.employees.Find(id);
            
            return View(employee);


        }
        public ActionResult UpdateData(employee employee)
        {
       
            db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("mainview");  
        }
        public ActionResult DeleteData(int id)
        {
            employee employee = db.employees.Find(id);
            db.employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("mainview");
        }
        public ActionResult SaveData(employee employee)
        {
         
            db.employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("mainview");
        }
    }

}