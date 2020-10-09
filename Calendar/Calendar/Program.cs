using System;
namespace Calendar
{

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CalendarContext())
            {

                /* db.Add(new User { id = 3, username = "Ira", email = "Ira123@gmail.com", password = "ira123" });
                 db.Add(new Event { id = 3, subject = "birthday", description = "", start = new DateTime(2021,9,10, 11, 0, 0),
                    end = new DateTime(2021,11,9, 11, 0, 0) });*/
                //db.Add(new UserEvent { id = 1, user_id = 1, event_id = 2 });
                //db.Add(new UserEvent { id = 2, user_id = 2, event_id = 3 });
                /*db.Add(new Event
                {
                    id = 1,
                    subject = "lesson",
                    description = "",
                    start = new DateTime(2020, 10, 9, 11, 0, 0),
                    end = new DateTime(2020, 10, 9, 12, 20, 0)
                });
                db.Add(new UserEvent { id = 3, user_id = 3, event_id = 1 });

                db.SaveChanges();*/

                var users = db.Users;
                Console.WriteLine("Users");
                foreach (User u in users)
                    Console.WriteLine((u.id, u.username, u.email, u.password));
                var events = db.Events;
                Console.WriteLine("Events");
                foreach (Event e in events)
                    Console.WriteLine((e.id, e.subject, e.description, e.start,e.end));
                var userevents = db.UserEvents;
                Console.WriteLine("UserEvents");
                foreach (UserEvent e in userevents)
                    Console.WriteLine((e.id, e.user_id, e.event_id));




            }
            
            
        }
    }
}
