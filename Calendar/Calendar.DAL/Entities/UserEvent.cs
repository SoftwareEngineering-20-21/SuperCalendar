using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.DAL.Entities
{
    class UserEvent
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public User User { get; set; }

        public int event_id { get; set; }
        public Event Event { get; set; }


    }
}
