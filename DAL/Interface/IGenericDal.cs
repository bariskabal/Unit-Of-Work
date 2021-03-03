namespace UowApp.DAL.Interface
{
    public interface IGenericDal<TEntity> where TEntity : class,new()
    {
         void Add(TEntity entity);
    }
}