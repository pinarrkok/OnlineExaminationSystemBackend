using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StudentCourse : IEntity
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
