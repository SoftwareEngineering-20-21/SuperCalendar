using System;
using System.Collections.Generic;
using Calendar.DAL.Abstractions;
namespace Calendar.DAL.Entities
{
    public class Event : BaseEntity
    {

        
        public string subject { get; set; }
        public string description { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public IEnumerable<UserEvent> users { get; set; }
    }
}
