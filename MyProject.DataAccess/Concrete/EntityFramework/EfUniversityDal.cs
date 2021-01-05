using Microsoft.EntityFrameworkCore;
using MyProject.Core.DataAccess.EntityFramework;
using MyProject.DataAccess.Abstract;
using MyProject.DataAccess.Concrete.EntityFramework.Context;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework
{
    public class EFUniversityDal : EfEntityRepositoryBase<MyDataContext, University>, IUniversityDal
    {
        public List<University> GetUniversityWithCityAndType()
        {
            using (var dB=new MyDataContext())
            {

                var universities =  dB.Universities.Include(i => i.City).Include(i => i.UniversityType).ToList();

                return universities;
            }
        }

        public List<University> GetUniversityWithQuery(int typeId, int cityId)
        {
            using (var dB = new MyDataContext())
            {

                var universities = dB.Universities.AsQueryable();
                universities = typeId > 0 ? universities.Where(i => i.UniversityTypeId == typeId) : universities;
                universities = cityId > 0 ? universities.Where(i => i.CityId == cityId) : universities;

                var finalUniversities = universities.Include(i => i.City).Include(i => i.UniversityType).ToList();
                return finalUniversities;
            }
        }
    }
}
