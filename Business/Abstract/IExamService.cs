using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IExamService
    {
        IDataResult<Exam> GetById(int examId);
        IDataResult<Exam> GetByTitle(string examTitle);
        IDataResult<Exam> GetByCourseName(string courseName);
        IDataResult<List<Exam>> GetList();
        IResult Add(ExamDto examDto);
        IResult Delete(int examId);
        IResult Update(int examId);
        IResult TransactionalOperation(Exam exam);
    }
}
