using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CourseInstructor : IEntity
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
    }
}
