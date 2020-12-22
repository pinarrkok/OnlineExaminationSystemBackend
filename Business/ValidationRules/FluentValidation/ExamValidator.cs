using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ExamValidator : AbstractValidator<Exam>
    {
        public ExamValidator()
        {
            RuleFor(e => e.Title).NotEmpty();
            RuleFor(e => e.Title).MaximumLength(50);

            RuleFor(e => e.Information).NotEmpty();
            RuleFor(e => e.Information).MaximumLength(250);

            RuleFor(e => e.NumberOfQuestions).NotEmpty();

            RuleFor(e => e.StartTime).NotEmpty();

            RuleFor(e => e.EndTime).NotEmpty();
        }
    }
}
