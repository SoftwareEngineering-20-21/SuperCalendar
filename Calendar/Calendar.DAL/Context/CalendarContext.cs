using Calendar.DAL.Entities;
using Microsoft.EntityFrameworkCore;


namespace Calendar.DAL.Context
{
    public class CalendarContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=Calendar.db");
        }
    }
}
