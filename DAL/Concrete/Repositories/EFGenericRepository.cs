using UowApp.DAL.Concrete.Context;
using UowApp.DAL.Interface;

namespace UowApp.DAL.Concrete.Repositories
{
    public class EFGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, new()
    {
        private readonly UowContext _context;
        public EFGenericRepository(UowContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Add(entity);
        }
    }
}