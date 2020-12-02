using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        IDataResult<User> GetById(int userId);
        User GetByMail(string email);
        User GetByName(string firstName);
        User GetByLastName(string lastName);
        IDataResult<List<User>> GetList();
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}