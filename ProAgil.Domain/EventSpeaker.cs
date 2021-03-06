﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProAgil.Domain
{
    public class EventSpeaker
    {
        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }
        public int EventId { get; set; }
        public Event Event { get; }
    }
}
