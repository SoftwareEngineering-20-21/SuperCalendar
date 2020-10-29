using System;
using System.Collections.Generic;
using System.Text;
using Calendar.DAL.Entities;

namespace Calendar.BLL.Interfaces
{
    public interface IEventService
    {
        bool Delete();
        bool Create(string subject, string description, DateTime start, DateTime end, IEnumerable<UserEvent> users);
        bool Edit(string subject, string description, DateTime start, DateTime end, IEnumerable<UserEvent> users);
    }
}
