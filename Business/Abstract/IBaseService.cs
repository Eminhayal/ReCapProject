using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBaseService <T>
    {
        IResult Add(T t);
        IResult Delete(T t);
        IResult Update(T t);
        IDataResult<List<T>> GetAll();
    }
}
