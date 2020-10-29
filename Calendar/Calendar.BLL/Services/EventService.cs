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

        public bool Create(string subject, string description, DateTime start, DateTime end, IEnumerable<UserEvent> users)
        {
            bool isCreated = false;
                if (CurrentUser != null)
                {
                    CurrentUser.events.Add(
                        new UserEvent
                        {
                            Event = new Event
                            {
                                subject = subject,
                                description = description,
                                start = start,
                                end = end,
                                users = users
                            }
                        });
                    unitOfWork.Repository<User>().Update(CurrentUser);
                    unitOfWork.SaveAsync();
                    isCreated=true;
                }
                return isCreated;
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Edit(string subject, string description, DateTime start, DateTime end, IEnumerable<UserEvent> users)
        {
            throw new NotImplementedException();
        }
    }
}
