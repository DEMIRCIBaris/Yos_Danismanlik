using MyProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.Concrete
{
    public class YosQuestions:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public string DocumentUrl { get; set; }
    }
}
