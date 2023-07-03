using book_reading_event.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IEventFactory
    {
        IEventMaster CreateEvent(int id, string username, int eventType, string title, DateTime date, string location, int duration, string description, string details, string invite);
    }

}
