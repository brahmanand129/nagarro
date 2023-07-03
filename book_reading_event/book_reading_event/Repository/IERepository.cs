
using book_reading_event.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_reading_event.Repository
{
    public interface IERepository
    {
        Task<List<EventMaster>> GetAllAsync();
        Task<EventMaster> GetByIdAsync(int eventId);
        void Add(EventMaster newEvent);
        void Remove(EventMaster existingEvent);
    }
}
