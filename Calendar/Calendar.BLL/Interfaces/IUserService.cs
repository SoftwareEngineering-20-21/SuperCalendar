using System;
using System.Collections.Generic;
using System.Text;
using Calendar.DAL.Entities;

namespace Calendar.BLL.Interfaces
{
    public interface IUserService
    {
        bool Login(string email, string password);
        bool SignUp(string fullname, string email, string password);
    }
}
