using UowApp.DAL.Concrete.Context;
using UowApp.DAL.Interface;
using UowApp.Entities;

namespace UowApp.DAL.Concrete.Repositories
{
    public class EFAccountRepository : EFGenericRepository<Account>,IAccountDal
    {
        public EFAccountRepository(UowContext context) : base(context)
        {
            
        }
    }
}