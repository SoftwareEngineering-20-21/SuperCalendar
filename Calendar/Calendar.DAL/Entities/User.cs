using System.Collections.Generic;
using Calendar.DAL.Abstractions;

namespace Calendar.DAL.Entities
{
    public class User: BaseEntity
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public virtual List<UserEvent> events { get; set; }
    }
}
