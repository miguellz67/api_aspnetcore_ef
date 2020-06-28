using ProAgil.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProAgil.Repository
{
    interface IProAgilRepository
    {
        // General
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        // Events
        Task<Event[]> GetEventsAsyncByTheme(string theme, bool includeSpeakers);
        Task<Event[]> GetEventsAsync(bool includeSpeakers);
        Task<Event> GetEventAsync(int EventId, bool includeSpeakers);

        // Speakers
        Task<Speaker[]> GetSpeakersAsync(bool includeEvents);
        Task<Speaker> GetSpeakerAsync(int SpeakerId, bool includeEvents);
    }
}
