using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : IServiceRepository<Customer>
    {
         ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get());
        }

        public IResult Add(Customer entity)
        {
           _customerDal.Add(entity);
           return new SuccessResult("Added");
        }

        public IResult Update(Customer entity)
        {
            _customerDal.Update(entity);
            return new SuccessResult("Updated");
        }

        public IResult Delete(Customer entity)
        {
           _customerDal.Delete(entity);
           return new SuccessResult("Deleted");
        }
    }
}
