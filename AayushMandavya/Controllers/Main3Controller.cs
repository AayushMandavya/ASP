using System;
using AayushMandavya.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AayushMandavya.Controllers
{
    public class Main3Controller : Controller
    {
        mainEntities db = new mainEntities();
        // GET: Main3
        public ActionResult mainview3()
        {
            List<employee_salary_details> data =db.employee_salary_details.ToList();
            return View(data);  
        }
        public ActionResult create3()
        {
            return View();
        }
        public ActionResult edit3(int id)
        {
            employee_salary_details employee_Salary_Details = db.employee_salary_details.Find(id);
            return View(employee_Salary_Details);
        }

        public ActionResult UpdateData3(employee_salary_details employee_Salary_Details)
        {
            db.Entry(employee_Salary_Details).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("mainview3");

                }

        public ActionResult DeleteData3(int id)  
        {
            employee_salary_details employee_Salary_Details = db.employee_salary_details.Find(id);
            db.employee_salary_details.Remove(employee_Salary_Details);
            db.SaveChanges();
            return RedirectToAction("mainview3");

        }
        public ActionResult SaveData3(employee_salary_details employee_Salary_Details)
        {
            db.employee_salary_details.Add(employee_Salary_Details);
            db.SaveChanges();
            return RedirectToAction("mainview3");
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}