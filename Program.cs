using System;
using Microsoft.Extensions.DependencyInjection;
using UowApp.BLL.Concrete;
using UowApp.BLL.Inteface;
using UowApp.DAL.Concrete.Context;
using UowApp.DAL.Concrete.Repositories;
using UowApp.DAL.Interface;
using UowApp.DAL.UnitOfWork;

namespace UowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new ServiceCollection().AddDbContext<UowContext>().AddScoped(typeof(IGenericService<>),typeof(GenericManager<>)).AddScoped(typeof(IGenericDal<>),typeof(EFGenericRepository<>)).AddScoped<IAccountService,AccountManager>().AddScoped<IUow,Uow>().BuildServiceProvider();
            var accountService = provider.GetService<IAccountService>();

            accountService.Add(new Entities.Account{
                CustomerName="bariss",
                Total=1500
            });
            Console.WriteLine("İşlem gerçekleşti");
        }
    }
}
