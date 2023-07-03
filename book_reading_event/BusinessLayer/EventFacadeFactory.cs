using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using book_reading_event.Models;

namespace FacadePattern
{
    public static class EventFacadeFactory
    {
        public static EventFacade CreateEventFacade(IEventFactory factory, int id, string username, int eventType, string title, DateTime date, string location, int duration, string description, string details, string invite)
        {
            IEventMaster eventObject = factory.CreateEvent(id, username, eventType, title, date, location, duration, description, details, invite);
            return new EventFacade(eventObject);
        }
    }

}
