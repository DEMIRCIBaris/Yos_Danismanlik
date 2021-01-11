using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WEB.Models
{
    public class GetViewModelUniversity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public string URL { get; set; }
        public string BasvuruTarih { get; set; }
        public string SinavTarihi { get; set; }
        public string SonucTarihi { get; set; }
        public City City { get; set; }
        public UniversityType UniversityType { get; set; }
        public bool IsAdded { get; set; }
    }
}
