using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calendar.BLL.Interfaces;
using Calendar.DAL.Entities;
using Calendar.DAL.Interfaces;
using Calendar.DAL.Repositories;


namespace Calendar.BLL.Services
{

    public class UserService : IUserService
    {
        private User currentUser = null;
        private readonly IUnitOfWork unitOfWork;

        public object BCrypt { get; private set; }

        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool Login(string Email, string Password)
        {
            User user = unitOfWork.Repository<User>().Get().FirstOrDefault(x => x.email == Email);
            if (user != null && (Password== user.password))
            {
                currentUser = user;
                return true;
            }
            {
                return false;
            }
        }

        
    }

}

