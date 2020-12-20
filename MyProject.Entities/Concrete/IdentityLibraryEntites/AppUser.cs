using Microsoft.AspNetCore.Identity;
using MyProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Entities.Concrete.IdentityLibraryEntites
{
    public class AppUser:IdentityUser<int>,IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; }

        public List<University> Universities { get; set; }
    }
}
