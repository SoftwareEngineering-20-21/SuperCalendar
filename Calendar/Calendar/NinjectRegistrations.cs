using System.Net.NetworkInformation;
using Calendar.BLL.Interfaces;
using Calendar.BLL.Services;
using Calendar.DAL.Context;
using Calendar.DAL.Entities;
using Calendar.DAL.Interfaces;
using Calendar.DAL.Repositories;
using Ninject.Modules;

namespace Calender
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<User>>().To<Repository<User>>().InSingletonScope();
            Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope();
            Bind<IUserService>().To<UserService>().InSingletonScope();
        }
    }
}