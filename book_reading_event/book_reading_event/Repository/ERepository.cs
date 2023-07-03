using book_reading_event.Models;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace book_reading_event.Repository
{
    public class ERepository : IERepository
    {
        private readonly ApplicationDbContext _context;

        public ERepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<EventMaster>> GetAllAsync()
        {
            return await _context.EventMaster.ToListAsync();
        }

        public async Task<EventMaster> GetByIdAsync(int eventId)
        {
            return await _context.EventMaster.FindAsync(eventId);
        }

        public void Add(EventMaster newEvent)
        {
            //_context.EventMain.Add(newEvent);
            _context.EventMaster.Add(newEvent);
        }

        public void Remove(EventMaster existingEvent)
        {
            _context.EventMaster.Remove(existingEvent);
        }
    }
}



