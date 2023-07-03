using System;
using book_reading_event.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Interface;

namespace book_reading_event.Controllers
{
    public class EventController : Controller
    {
        private IEvent1 event1 = null;

        public EventController(IEvent1 events1)
        {
            event1 = events1;

        }

        ApplicationDbContext _db;
        public EventController()
        {
            _db = new ApplicationDbContext();
        }


       [HttpGet]
        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Create(Event1 E)
        {
            _db.Event1.Add(E);
            _db.SaveChanges();
            return View();
        }

        public ActionResult EventTypeList()
        {
            var EventList = _db.Event1.ToList();
            return View(EventList);
        }

        public ActionResult Edit(int id)
        {
            var EventType = _db.Event1.FirstOrDefault(a => a.Id == id);
            return View("Create", EventType);
        }
        public ActionResult Delete(int id)
        {

            var dataForDeletre = _db.Event1.FirstOrDefault(a => a.Id == id);
            _db.Event1.Remove(dataForDeletre);
            _db.SaveChanges();
            return RedirectToAction("EventTypeList");

        }



    }
       
    
}