using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ExamManager : IExamService
    {
        private IExamDal _examDal;

        public ExamManager(IExamDal examDal)
        {
            _examDal = examDal;
        }

        [ValidationAspect(typeof(ExamValidator), Priority = 1)]
        [CacheRemoveAspect("IExamService.Get")]
        public IResult Add(ExamDto examDto)
        {            
            var exam = new Exam
            {
                Title = examDto.Title,
                Information = examDto.Information,
                NumberOfQuestions = examDto.NumberOfQuestions,
                AddedAt = DateTime.Now,
                StartTime = DateTime.Parse(examDto.StartTime),
                EndTime = DateTime.Parse(examDto.EndTime)
            };

            _examDal.Add(exam);
            return new SuccessResult(Messages.ExamAdded);
        }

        public IResult Delete(int examId)
        {
            _examDal.Delete(_examDal.Get(filter: exam => exam.Id == examId));
            return new SuccessResult(Messages.ExamDeleted);
        }

        public IDataResult<Exam> GetByCourseName(string courseName)
        {
            // İki tabloyu nasıl birleştiricem burda ?! OFOFF
            throw new NotImplementedException();
        }

        // bu operasyonun çalışması 5 snyi geçerse
        [PerformanceAspect(5)]
        public IDataResult<Exam> GetById(int examId)
        {
            return new SuccessDataResult<Exam>(_examDal.Get(filter: exam => exam.Id == examId));
        }

        public IDataResult<Exam> GetByTitle(string examTitle)
        {
            return new SuccessDataResult<Exam>(_examDal.Get(filter: exam => exam.Title == examTitle));
        }

        [SecuredOperation("Student.List")]
        [LogAspect(typeof(FileLogger))]
        [CacheAspect(10)]
        public IDataResult<List<Exam>> GetList()
        {
            return new SuccessDataResult<List<Exam>>(_examDal.GetList().ToList());
        }

        // Add başarılı olmazsa Update'i geri al (try'daki proceed kısmı) 
        [TransactionScopeAspect]
        public IResult TransactionalOperation(Exam exam)
        {
            _examDal.Update(exam);
            _examDal.Add(exam);
            return new SuccessResult(Messages.ExamUpdated);
        }

        public IResult Update(int examId)
        {
            _examDal.Update(_examDal.Get(filter: exam => exam.Id == examId));
            return new SuccessResult(Messages.ExamUpdated);
        }
    }
}
