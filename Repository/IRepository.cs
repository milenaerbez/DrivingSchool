using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<TEntity> where TEntity : class

    {

        void Add(TEntity entity);
        void Delete(TEntity entity);    
        List<TEntity> GetAll(TEntity entity);
        List<TEntity> Search(TEntity entity, string condition);
        List<IEntity> Pretrazi(IEntity entity, string condition);
        void Update(TEntity entity, string setValues);

    }
}
