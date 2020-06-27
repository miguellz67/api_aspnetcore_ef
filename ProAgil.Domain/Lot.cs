using System;
using System.Collections.Generic;
using System.Text;

namespace ProAgil.Domain
{
    public class Lot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime? beginDate { get; set; }
        public DateTime? endDate { get; set; }
        public int Amount { get; set; }
        
        //Relation EF
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
