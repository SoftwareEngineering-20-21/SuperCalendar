using Calendar.DAL.Entities;
using System;
using Calendar.DAL.Repositories;
using System.Threading.Tasks;
using Calendar.DAL.Abstractions;


namespace Calendar.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : BaseEntity;
        void Save();
        Task SaveAsync();
    }
}