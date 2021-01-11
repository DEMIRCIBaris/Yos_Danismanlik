using MyProject.Core.Bussiness;
using MyProject.Entities.Concrete;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.Abstract
{
    public interface IUniversityService:IGenericService<University>
    {
        public List<University> GetUniversityWithCityAndType();
        List<University> GetUniversityWithCityAndType(string search);
        public List<University> GetUniversityWithQuery(int typeId, int cityId);
        List<AppUser> GetUniversitiesUsers(int universityId);

    }
}
