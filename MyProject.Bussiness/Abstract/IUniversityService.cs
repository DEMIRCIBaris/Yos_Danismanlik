using MyProject.Core.Bussiness;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.Abstract
{
    public interface IUniversityService:IGenericService<University>
    {
        public List<University> GetUniversityWithCityAndType();
        public List<University> GetUniversityWithQuery(int typeId, int cityId);
        
    }
}
