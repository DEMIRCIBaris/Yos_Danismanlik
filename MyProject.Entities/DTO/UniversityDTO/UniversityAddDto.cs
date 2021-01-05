﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.DTO.UniversityDTO
{
    public class UniversityAddDto
    {
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public string URL { get; set; }
        public DateTime BasvuruTarih { get; set; }
        public DateTime SinavTarihi { get; set; }
        public DateTime SonucTarihi { get; set; }
        public int CityId { get; set; }
        public int UniversityTypeId { get; set; }
    }

}