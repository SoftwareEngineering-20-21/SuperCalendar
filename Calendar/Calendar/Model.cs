using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Calendar
{
    public class CalendarContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=calendar.db");
    }
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public IEnumerable<UserEvent> events { get; set; }

    }
    public class Event
    {

        public int id { get; set; }
        public string subject { get; set; }
        public string description { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        //public string emails { get; set; }
        public IEnumerable<UserEvent> users { get; set; }

    }
    public class UserEvent
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public User User { get; set; }

        public int event_id { get; set; }
        public Event Event { get; set; }


}

}
