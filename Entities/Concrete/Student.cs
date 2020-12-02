using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string StudentId { get; set; }
        public string Semester { get; set; }
    }
}
