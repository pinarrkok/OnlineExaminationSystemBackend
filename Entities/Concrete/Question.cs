using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Question : IEntity
    { 
        public int Id { get; set; }
        public string Detail { get; set; }
        public char AnswerOption { get; set; }
    }
}
