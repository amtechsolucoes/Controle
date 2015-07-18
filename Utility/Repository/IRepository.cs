using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Entity;

namespace Utility.Repository
{
    public interface IRepository<TEntity> where TEntity: EntityBase
    {
        IQueryable<TEntity> List();
        void Save(TEntity entity);
        void Remove(TEntity entity);
        void SearchForId(Guid? key);
        void Execute();
    }
}
