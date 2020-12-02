using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStudentService
    {
        IDataResult<Student> GetById(int userId);
        Student GetByStudentId(string studentId);
        IDataResult<List<Student>> GetList();
        IResult Add(Student student);
        IResult Delete(Student student);
        IResult Update(Student student);
    }
}
