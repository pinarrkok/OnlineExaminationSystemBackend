using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Exam : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Information { get; set; }
        public int NumberOfQuestions { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
