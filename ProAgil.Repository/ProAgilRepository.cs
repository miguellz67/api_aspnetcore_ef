using Microsoft.EntityFrameworkCore;
using ProAgil.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProAgil.Repository
{
    class ProAgilRepository : IProAgilRepository
    {
        private readonly DataContext _context;
        public ProAgilRepository(DataContext context)
        {
            _context = context;
        }

        
        // General
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        // Events
        public async Task<Event> GetEventAsync(int EventId, bool includeSpeakers = false)
        {
            IQueryable<Event> query = _context.Events.Include(c => c.Lots).Include(c => c.SocialNetWorks);

            if (includeSpeakers)
            {
                query = query.Include(pe => pe.EventSpeakers).ThenInclude(p => p.Speaker);
            }

            query = query.OrderByDescending(c => c.Date).Where(c => c.Id == EventId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Event[]> GetEventsAsync(bool includeSpeakers = false)
        {
            IQueryable<Event> query = _context.Events.Include(c => c.Lots).Include(c => c.SocialNetWorks);

            if (includeSpeakers)
            {
                query = query.Include(pe => pe.EventSpeakers).ThenInclude(p => p.Speaker);
            }

            query = query.OrderByDescending(c => c.Date);

            return await query.ToArrayAsync();
        }

        public async Task<Event[]> GetEventsAsyncByTheme(string theme, bool includeSpeakers = false)
        {
            IQueryable<Event> query = _context.Events.Include(c => c.Lots).Include(c => c.SocialNetWorks);

            if (includeSpeakers)
            {
                query = query.Include(pe => pe.EventSpeakers).ThenInclude(p => p.Speaker);
            }

            query = query.OrderByDescending(c => c.Date).Where(c => c.Theme.ToLower().Contains(theme.ToLower()));

            return await query.ToArrayAsync();
        }

        // Speakers
        public async Task<Speaker> GetSpeakerAsync(int SpeakerId, bool includeEvents)
        {
            IQueryable<Speaker> query = _context.Speakers.Include(c => c.SocialNetWorks);

            if (includeEvents)
            {
                query = query.Include(pe => pe.EventSpeakers).ThenInclude(p => p.Event);
            }

            query = query.OrderBy(c => c.Name).Where(c => c.Id == SpeakerId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Speaker[]> GetSpeakersAsync(bool includeEvents)
        {
            IQueryable<Speaker> query = _context.Speakers.Include(c => c.SocialNetWorks);

            if (includeEvents)
            {
                query = query.Include(pe => pe.EventSpeakers).ThenInclude(p => p.Event);
            }

            query = query.OrderBy(c => c.Name);

            return await query.ToArrayAsync();
        }

        

        
    }
}
