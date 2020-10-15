using Calendar.DAL.Entities;
using System;


namespace Calendar.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Event> Events { get; }
        IRepository<UserEvent> UserEvents { get; }
        void Save();
    }
}