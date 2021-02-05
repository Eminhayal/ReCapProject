using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        // Generic Constraint
        // Class : Referans tip olabilir
        // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
        //New : New'lenebilir olmalidir.
        List<T> GetAll(Expression<Func<T,bool>> filter= null );
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
