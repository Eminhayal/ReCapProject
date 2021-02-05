using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBaseService <T>
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetAll();
    }
}
