using MyProject.Bussiness.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyProject.Bussiness.Concrete
{
    public class UniversityService : IUniversityService
    {
        private readonly IUniversityDal universityDal;

        public UniversityService(IUniversityDal universityDal)
        {
            this.universityDal = universityDal;
        }

        public void Add(University entity)
        {
            universityDal.Add(entity);
        }

        public void Delete(University entity)
        {
            universityDal.Delete(entity);
        }

        public University Get(Expression<Func<University, bool>> filter)
        {
            var university = universityDal.Get(filter);
            return university;
        }

        public List<University> GetList(Expression<Func<University, bool>> filter = null)
        {
            var universities = universityDal.GetList(filter);
            return universities;
        }

        public List<University> GetUniversityWithCityAndType()
        {
            var universities = universityDal.GetUniversityWithCityAndType();
            return universities;
        }

        public List<University> GetUniversityWithQuery(int typeId, int cityId)
        {
            var universities = universityDal.GetUniversityWithQuery(typeId, cityId);
            return universities;
        }

        public void Update(University entity)
        {
            universityDal.Update(entity);
        }
    }
}
