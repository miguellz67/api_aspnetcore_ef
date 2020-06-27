using ProAgil.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProAgil.Repository
{
    class ProAgilRepository : IProAgilRepository
    {
        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<Event> GetEventAsync(int EventId, bool includeSpeakers)
        {
            throw new NotImplementedException();
        }

        public Task<Event[]> GetEventsAsync(bool includeSpeakers)
        {
            throw new NotImplementedException();
        }

        public Task<Event[]> GetEventsAsyncByTheme(string theme, bool includeSpeakers)
        {
            throw new NotImplementedException();
        }

        public Task<Speaker> GetSpeakerAsync(int SpeakerId)
        {
            throw new NotImplementedException();
        }

        public Task<Speaker[]> GetSpeakersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
