using AayushMandavya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AayushMandavya.Controllers
{
    public class Main1Controller : Controller
    {
        mainEntities db = new mainEntities();
        // GET: Main1
        public ActionResult mainview1()
        {
            List<student> data = db.students.ToList();
            return View(data);
        }
    }
}