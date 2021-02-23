using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IServiceRepository<User>
    {

        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User entity)
        {
            _userDal.Add(entity);
            return new SuccessResult("Added");
        }

        public IResult Delete(User entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult("Deleted");
        }

        public IDataResult<User> Get()
        {
            return new SuccessDataResult<User>(_userDal.Get());
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IResult Update(User entity)
        {
            _userDal.Update(entity);
            return new SuccessResult("Updated");
        }
    }
}
