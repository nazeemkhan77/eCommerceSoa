namespace eCommerceSoa.DataAccess.Contract
{
    public interface IRepository<T>
    {
        void Create(T product);
        void Update(T product);
        void Delete(T product);

        T GetById(long id);
        
        void Save();
    }
}
