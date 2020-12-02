using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ExamResult : IEntity
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public int ExamId { get; set; }
        public int Score { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
