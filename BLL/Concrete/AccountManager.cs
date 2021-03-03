using UowApp.BLL.Inteface;
using UowApp.DAL.UnitOfWork;
using UowApp.Entities;

namespace UowApp.BLL.Concrete
{
    public class AccountManager : GenericManager<Account>,IAccountService
    {
        private readonly IUow _uow;
        public AccountManager(IUow uow) : base(uow)
        {
            _uow = uow;
        }
    }
}