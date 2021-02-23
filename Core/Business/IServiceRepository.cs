using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Business
{
    public interface IServiceRepository<T>
    {
        IDataResult<List<T>> GetAll();
        IDataResult<T> Get();
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);

   

    }
}
