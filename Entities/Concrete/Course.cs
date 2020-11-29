using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime AddedAt { get; set; }
    }
}
