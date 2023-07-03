using book_reading_event.Models;
using PurchaseSystem.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PurchaseSystem.Controllers
{
    [Authorize]
    public class UserHomeController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        // GET: UserHome
        public ActionResult DisplayModule()
        {
            List<ModuleMst> ModuleList;
            if (User.IsInRole("Admin"))
            {
                ModuleList = _db.ModuleMst.Where(a => a.IsActive == 1).ToList();
            }
           
            else
            {
                ModuleList = _db.ModuleMst.Where(a => a.IsActive == 1 && a.pk_moduleid == 2).ToList();
            }
            return View(ModuleList);
        }

    }
}