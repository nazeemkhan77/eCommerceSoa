using System.Collections.Generic;

namespace eCommerceSoa.DataAccess.Contract
{
    public interface IUnitOfWork
    {
        IList<IEntity> NewEntities { get; set; }
        IList<IEntity> ChangedEntities { get; set; }
        IList<IEntity> RemovedEntities { get; set; }

        bool Commit();
        void Rollback();
    }
}