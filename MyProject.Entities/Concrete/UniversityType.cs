using MyProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.Concrete
{
    public class UniversityType:IEntity
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public List<University> Universities { get; set; }
    }
}
