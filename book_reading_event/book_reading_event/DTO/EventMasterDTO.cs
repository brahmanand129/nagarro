using book_reading_event.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace book_reading_event.DTO
{
    public class EventMasterDTO
    {
        public List<Event1> EventList { get; set; }
        public EventMaster EventMaster { get; set; }
        public List<Event1> EventTypeList { get; set; }
    }
}