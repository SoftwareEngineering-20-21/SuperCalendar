using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.DAL.Entities
{
    class Event
    {

        public int id { get; set; }
        public string subject { get; set; }
        public string description { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public IEnumerable<UserEvent> users { get; set; }
    }
}
