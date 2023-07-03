using book_reading_event.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace book_reading_event.Controllers
{
    public class ModuleController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        public ActionResult ModuleList()
        {

            return View(_db.ModuleMst.ToList());
        }
        [HttpGet]
        public ActionResult CreateModule()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateModule(ModuleMst module)
        {
            _db.ModuleMst.Add(module);
            _db.SaveChanges();
            return View();
        }

    }
}