using Calendar.DAL.Abstractions;
namespace Calendar.DAL.Entities
{
    public class UserEvent : BaseEntity
    { 
        public int user_id { get; set; }
        public User User { get; set; }

        public int event_id { get; set; }
        public Event Event { get; set; }


    }
}
