using UowApp.BLL.Inteface;
using UowApp.DAL.UnitOfWork;

namespace UowApp.BLL.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, new()
    {
        private readonly IUow _uow;
        public GenericManager(IUow uow)
        {
            _uow = uow;
        }
        public void Add(TEntity entity)
        {
            _uow.GetRepository<TEntity>().Add(entity);
            _uow.SaveChanges();
        }
    }
}