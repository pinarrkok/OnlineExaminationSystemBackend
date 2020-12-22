using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ExamDto : IDto
    {
        public string Title { get; set; }
        public string Information { get; set; }
        public int NumberOfQuestions { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
