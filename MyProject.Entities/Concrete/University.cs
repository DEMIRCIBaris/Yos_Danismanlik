using MyProject.Core.Entities.Abstract;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.Concrete
{
    public class University:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public DateTime BasvuruTarih { get; set; }
        public DateTime SinavTarihi { get; set; }
        public DateTime SonucTarihi { get; set; }

        public string URL { get; set; }

        public List<UserUniversity> UsersUniversities { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public int UniversityTypeId { get; set; }
        public UniversityType UniversityType { get; set; }

    }
}
