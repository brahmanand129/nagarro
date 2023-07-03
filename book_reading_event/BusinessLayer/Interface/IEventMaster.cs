using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_reading_event.Models
{
    public interface IEventMaster
    {
        int Id { get; set; }
        string username { get; set; }

        int Event_Type { get; set; }

        string Title { get; set; }

        DateTime Date { get; set; }

        string Location { get; set; }

        int Duration { get; set; }
        string Description { get; set; }
        string Details { get; set; }
        string Invite { get; set; }
    }
}
