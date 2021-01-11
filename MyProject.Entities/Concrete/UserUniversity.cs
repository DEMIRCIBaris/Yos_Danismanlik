using MyProject.Core.Entities.Abstract;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.Concrete
{
   public class UserUniversity:IEntity
    {
        public int UsersId { get; set; }
        public AppUser AppUser { get; set; }


        public int UniversitiesId { get; set; }
        public University University { get; set; }
    }
}
