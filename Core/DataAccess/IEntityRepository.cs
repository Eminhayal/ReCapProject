
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Entities
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        // Generic Constraint
        // Class : Referans tip olabilir
        // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
        //New : New'lenebilir olmalidir.


        List<T> GetAll(Expression<Func<T,bool>> filter= null );
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity); // Generic parametreli methodlar 
        void Delete(T entity);
        void Update(T entity);
    }
}
