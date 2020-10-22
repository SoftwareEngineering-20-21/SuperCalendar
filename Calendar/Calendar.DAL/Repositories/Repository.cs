using Calendar.DAL.Context;
using Calendar.DAL.Abstractions;
using System.Threading.Tasks;
using Calendar.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Calendar.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly CalendarContext context;
        private readonly DbSet<T> dbSet;
        public Repository()
        {
            this.context = new CalendarContext();
            dbSet = context.Set<T>();
            dbSet.Load();
        }
        public Repository(CalendarContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        public IEnumerable<T> Get()
        {
            return dbSet.ToList();
        }

        public T Get(int id)
        {
            return dbSet.FirstOrDefault(x => x.Id == id);
        }
        public IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return dbSet.Where(predicate).ToList();
        }
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Delete(int id)
        {
            T elem = dbSet.Find(id);
            if (elem != null)
            {
                dbSet.Remove(elem);
            }
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }

}