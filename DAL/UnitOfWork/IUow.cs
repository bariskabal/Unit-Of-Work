using UowApp.DAL.Interface;

namespace UowApp.DAL.UnitOfWork
{
    public interface IUow
    {
        IGenericDal<TEntity> GetRepository<TEntity>() where TEntity : class, new();
        IAccountDal AccountDal { get; set; }
        void SaveChanges();
    }
}