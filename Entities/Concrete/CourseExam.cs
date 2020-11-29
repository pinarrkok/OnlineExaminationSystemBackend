using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CourseExam : IEntity
    {
        public int CourseId { get; set; }
        public int ExamId { get; set; }
    }
}
