using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_reading_event.Models
{
    public class EventFacade
    {
        private IEventMaster _eventMaster;

        public EventFacade(IEventMaster eventMaster)
        {
            _eventMaster = eventMaster;
        }

        public int Id
        {
            get { return _eventMaster.Id; }
            set { _eventMaster.Id = value; }
        }

        public string username
        {
            get { return _eventMaster.username; }
            set { _eventMaster.username = value; }
        }

        public int Event_Type
        {
            get { return _eventMaster.Event_Type; }
            set { _eventMaster.Event_Type = value; }
        }

        public string Title
        {
            get { return _eventMaster.Title; }
            set { _eventMaster.Title = value; }
        }

        public DateTime Date
        {
            get { return _eventMaster.Date; }
            set { _eventMaster.Date = value; }
        }

        public string Location
        {
            get { return _eventMaster.Location; }
            set { _eventMaster.Location = value; }
        }

        public int Duration
        {
            get { return _eventMaster.Duration; }
            set { _eventMaster.Duration = value; }
        }

        public string Description
        {
            get { return _eventMaster.Description; }
            set { _eventMaster.Description = value; }
        }

        public string Details
        {
            get { return _eventMaster.Details; }
            set { _eventMaster.Details = value; }
        }

        public string Invite
        {
            get { return _eventMaster.Invite; }
            set { _eventMaster.Invite = value; }
        }
    }
}
