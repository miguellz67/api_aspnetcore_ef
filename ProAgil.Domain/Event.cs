using System;
using System.Collections.Generic;

namespace ProAgil.Domain
{
    public class Event
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Theme { get; set; }
        public int Peoples { get; set; }
        public string imgURL { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        // Relation EF
        public IEnumerable<Lot> Lots { get; set; }
        public IEnumerable<SocialNetWork> SocialNetWorks { get; set; }
        public IEnumerable<EventSpeaker> EventSpeakers { get; set; }
    }
}
