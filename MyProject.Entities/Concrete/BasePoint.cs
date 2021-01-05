using MyProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.Concrete
{
    public class BasePoint : IEntity
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string FirstCities { get; set; }
        public string SecondCities { get; set; }
        public string ThirdCities { get; set; }
    }
}
