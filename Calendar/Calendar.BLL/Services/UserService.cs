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
        public readonly IUnitOfWork unitOfWork = null;


        public bool Login(string Email, string Password)
        {
            User user = unitOfWork.Repository<User>().Get().FirstOrDefault(x => x.email == Email);
            bool isLoged = false;
            if (user != null && (Password== user.password))
            {
                currentUser = user;
                isLoged = true;
            }
            return isLoged;
            
        }

        public bool SignUp(string Fullname, string Email, string Password)
        {

            bool isSigned = false;
            
                var existUser = unitOfWork.Repository<User>().Get().FirstOrDefault(x => x.email == Email);

                if (existUser == null)
                {
                    User user = new User
                    {
                        username = Fullname,
                        email = Email,
                        password = Password,
                        events = new List<UserEvent>()
                    };
                    unitOfWork.Repository<User>().Update(user);
                    unitOfWork.Save();
                    currentUser = user;
                    isSigned = true;
                }

            
                return isSigned;
            
        }

    }

}

