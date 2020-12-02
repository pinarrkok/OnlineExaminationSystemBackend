using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class QuestionOption : IEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public char OptionOrder { get; set; }
        public string Detail { get; set; }
    }
}
