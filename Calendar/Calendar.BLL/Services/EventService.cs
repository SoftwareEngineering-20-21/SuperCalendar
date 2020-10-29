using Calendar.BLL.Interfaces;
using Calendar.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Calendar.DAL.Interfaces;

namespace Calendar.BLL.Services
{
    public class EventService : IEventService
    {
        public User CurrentUser { get; set; }
       
        private readonly IUnitOfWork unitOfWork;
        public EventService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool CreateEvent(Event events)
        {
            bool isCreated = false;
                if (CurrentUser != null)
                {
                CurrentUser.events.Add(
                    new UserEvent
                    {
                        Event = events,
                        user_id = CurrentUser.Id

                    }); ;
                    unitOfWork.Repository<User>().Update(CurrentUser);
                    unitOfWork.Repository<Event>().Update(events);
                    unitOfWork.SaveAsync();
                    isCreated=true;
                }
                return isCreated;
        }

       public bool EditEvent(Event events) 
        {
            unitOfWork.Repository<Event>().Update(events);
            unitOfWork.Save();
            return true;
        }

       
        
        public bool DeleteEvent(Event events)
        {
            try
            {
                unitOfWork.Repository<Event>().Delete(events);
                unitOfWork.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
