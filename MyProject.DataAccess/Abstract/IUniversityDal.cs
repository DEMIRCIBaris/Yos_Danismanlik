using MyProject.Core.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Abstract
{
   public interface IUniversityDal : IEntityRepository<University>
    {
        List<University> GetUniversityWithCityAndType();
        List<University> GetUniversityWithCityAndType(string search);
        List<University> GetUniversityWithQuery(int typeId, int cityId);
        List<AppUser> GetUniversitiesUsers(int universityId);
    }
}
