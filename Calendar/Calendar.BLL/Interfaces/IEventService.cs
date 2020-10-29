using System;
using System.Collections.Generic;
using System.Text;
using Calendar.DAL.Entities;

namespace Calendar.BLL.Interfaces
{
    public interface IEventService
    {
        bool DeleteEvent(Event events);
        bool CreateEvent(Event events);
        bool EditEvent(Event events);
    }
}
