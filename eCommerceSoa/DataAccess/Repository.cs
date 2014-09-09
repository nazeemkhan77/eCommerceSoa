using eCommerceSoa.DataAccess.Contract;

namespace eCommerceSoa.DataAccess
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        private readonly ICommandHandler _requestHandler;
        private readonly IUnitOfWork _unitOfWork;

        public Repository(ICommandHandler requestHandler, IUnitOfWork unitOfWork)
        {
            _requestHandler = requestHandler;
            _unitOfWork = unitOfWork;
        }

        public void Create(T obj)
        {
            _unitOfWork.NewEntities.Add(obj);
        }

        public void Update(T obj)
        {
            _unitOfWork.ChangedEntities.Add(obj);
        }

        public void Delete(T obj)
        {
            _unitOfWork.RemovedEntities.Add(obj);
        }

        public T GetById(long id)
        {
            return _requestHandler.Execute<long, T>(id);
        }

        public void Save()
        {
            if(_unitOfWork.Commit())
                _unitOfWork.Rollback();
        }
    }
}
