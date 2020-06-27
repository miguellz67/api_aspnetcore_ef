using System;
using System.Collections.Generic;
using System.Text;

namespace ProAgil.Domain
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string imgURL { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        // Relation EF
        public IEnumerable<SocialNetWork> SocialNetWorks { get; set; }

        public IEnumerable<EventSpeaker> EventSpeakers { get; set; }
    }
}
