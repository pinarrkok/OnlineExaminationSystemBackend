using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public IResult Add(Student student)
        {
            _studentDal.Add(student);
            return new SuccessResult(Messages.StudentAdded);
        }

        public IResult Delete(Student student)
        {
            _studentDal.Delete(student);
            return new SuccessResult(Messages.StudentDeleted);
        }

        public IDataResult<Student> GetById(int userId)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(filter: student => student.UserId == userId));
        }

        public IDataResult<Student> GetByStudentId(string studentId)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(s => s.StudentId == studentId));
        }

        public IDataResult<List<Student>> GetList()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetList().ToList());
        }

        public IResult Update(Student student)
        {
            _studentDal.Update(student);
            return new SuccessResult(Messages.StudentUpdated);
        }
    }
}
