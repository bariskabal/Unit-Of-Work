namespace UowApp.BLL.Inteface
{
    public interface IGenericService<TEntity> where TEntity : class,new()
    {
         void Add(TEntity entity);
    }
}