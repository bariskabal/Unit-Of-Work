using UowApp.DAL.Concrete.Context;
using UowApp.DAL.Concrete.Repositories;
using UowApp.DAL.Interface;

namespace UowApp.DAL.UnitOfWork
{
    public class Uow : IUow
    {
        public IAccountDal AccountDal {get;set; }
        private readonly UowContext _context;
        public Uow(UowContext context)
        {
            _context= context;
            AccountDal = new EFAccountRepository(_context);
        }
        public IGenericDal<TEntity> GetRepository<TEntity>() where TEntity : class,new()
        {
            return new EFGenericRepository<TEntity>(_context);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}