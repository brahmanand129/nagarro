using book_reading_event.DTO;
using book_reading_event.Models;
using Logger;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace book_reading_event.Controllers
{
    [Authorize]
    public class EventMainController : Controller
    {
        private IEventMaster eventMaster = null;

        public EventMainController(IEventMaster eventMasters)
        {
            eventMaster = eventMasters;

        }
      
        private iLog _iLog;
        private ApplicationDbContext _db = new ApplicationDbContext();
        public EventMainController()
        {
            _iLog = Log.GetInstance;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            _iLog.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
        [HttpGet]
        public ActionResult AddUpdateEvent()
        {
            var pageLoadData = new EventMasterDTO
            {
                EventList = _db.Event1.ToList()
            };

            return View(pageLoadData);
        }

        [Authorize]
        public ActionResult EventsInvitedTo()
        {
            var userEmailID = this.User.Identity.Name;
            var invitedEventID = _db.EventMaster
            .Where(e => e.Invite == userEmailID)
            .Select(e => e.Invite).ToList();
            var events = this._db.EventMaster.Where(e => invitedEventID.Contains(e.Invite));
            return View(events.ToList());
        }


        public ActionResult EventList()
        {
            IEnumerable<EventListDTO> EventList;
            if (User.IsInRole("Admin"))
            {
                EventList = from a in _db.EventMaster
                            join b in _db.Event1 on a.Event_Type equals b.Id
                            select new EventListDTO
                            {
                                Id = a.Id,
                                EventType = b.Title,
                                Title = a.Title,
                                Date = a.Date,

                                Location = a.Location,
                               

                                Duration = a.Duration,
                                Description = a.Description,
                                Details = a.Details,
                                Invite = a.Invite
                            };

            }
            else
            {
                EventList = from a in _db.EventMaster
                            join b in _db.Event1 on a.Event_Type equals b.Id
                            where a.username == User.Identity.Name
                            select new EventListDTO
                            {
                                Id = a.Id,
                                EventType = b.Title,
                                Title = a.Title,
                                Date = a.Date,
                                Location = a.Location,
                              
                                Duration = a.Duration,
                                Description = a.Description,
                                Details = a.Details,
                                Invite = a.Invite
                            };
            }


            return View(EventList);
        }

        public ActionResult Edit(int id)
        {
            var EditData = new EventMasterDTO
            {
                EventMaster = _db.EventMaster.FirstOrDefault(a => a.Id == id),
                EventList = _db.Event1.ToList()
            };
            return View("AddUpdateEvent", EditData);

        }
        public ActionResult Delete(int id)
        {

            var dataForDeletre = _db.EventMaster.FirstOrDefault(a => a.Id == id);
            _db.EventMaster.Remove(dataForDeletre);
            _db.SaveChanges();
            return RedirectToAction("EventList");

        }


        [HttpPost]
        public ActionResult AddUpdateEvent(EventMasterDTO E)
        {
            if (E.EventMaster.Id == 0)
            {
                E.EventMaster.username = User.Identity.Name;
                _db.EventMaster.Add(E.EventMaster);
                _db.SaveChanges();
            }
            else
            {
                var dataInDb = _db.EventMaster.FirstOrDefault(a => a.Id == E.EventMaster.Id);

                dataInDb.Event_Type = E.EventMaster.Event_Type;
                dataInDb.Title = E.EventMaster.Title;
                dataInDb.Date = E.EventMaster.Date;
                dataInDb.Location = E.EventMaster.Location;
               
                //dataInDb.Type = E.EventMaster.Type;
                dataInDb.Duration = E.EventMaster.Duration;
                dataInDb.Description = E.EventMaster.Description;
                dataInDb.Details = E.EventMaster.Details;
                dataInDb.Invite = E.EventMaster.Invite;
                _db.SaveChanges();
            }


            return RedirectToAction("EventList");
        }
    }
}