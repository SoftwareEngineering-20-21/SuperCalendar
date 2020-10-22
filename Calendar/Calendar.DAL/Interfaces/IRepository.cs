﻿using Calendar.DAL.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Calendar.DAL.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(Func<T, bool> predicate);
        T Get(int id);
        void Delete(T entity);
        void Delete(int id);
        void Update(T entity);
        void Save();
        Task SaveAsync();
    }
}