namespace StoreOfBuild.Domain
{
    public interface IRepository
    {
        TEntity GetById(int id);
        void Save(TEntity entity);
    }