using MyProject.Core.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Abstract
{
   public interface IUniversityDal : IEntityRepository<University>
    {
        List<University> GetUniversityWithCityAndType();
        List<University> GetUniversityWithQuery(int typeId, int cityId);
    }
}
