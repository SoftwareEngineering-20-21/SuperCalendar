using NLayerApp.DAL.Entities;
using System;

namespace NLayerApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Event> Events { get; }
        IRepository<UserEvent> UserEvents { get; }
        void Save();
    }
}