using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.DAL.Entities
{
    class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public IEnumerable<UserEvent> events { get; set; }
    }
}
