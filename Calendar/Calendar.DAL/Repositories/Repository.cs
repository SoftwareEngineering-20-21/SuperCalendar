using Calendar.DAL.Entities;
using Calendar.DAL.Context;
using Calendar.DAL.Abstractions;
using Calendar.DAL.Entities;
using Calendar.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calendar.DAL.Repositories
{
    class UserRepository : IRepository<User>
    {
        private CalendarContext db;

        public UserRepository(CalendarContext context)
        {
            this.db = context;
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public void Update(User user)
        {
            db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IEnumerable<User> Find(Func<User, Boolean> predicate)
        {
            return db.Users.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
        }
    }
}