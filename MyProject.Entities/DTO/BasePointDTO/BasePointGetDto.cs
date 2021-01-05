using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.DTO.BasePointDTO
{
    public class BasePointGetDto
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string FirstCities { get; set; }
        public string SecondCities { get; set; }
        public string ThirdCities { get; set; }
    }
}
