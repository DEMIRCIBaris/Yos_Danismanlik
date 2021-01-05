using MyProject.Bussiness.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyProject.Bussiness.Concrete
{
    public class UnıversityTypeService : IUniversityTypeService
    {
        private readonly IUniversityTypeDal universityTypeDal;

        public UnıversityTypeService(IUniversityTypeDal universityTypeDal)
        {
            this.universityTypeDal = universityTypeDal;
        }

        public void Add(UniversityType entity)
        {
            universityTypeDal.Add(entity);
        }

        public void Delete(UniversityType entity)
        {
            universityTypeDal.Delete(entity);
        }

        public UniversityType Get(Expression<Func<UniversityType, bool>> filter)
        {
            var universityType = universityTypeDal.Get(filter);
            return universityType;
        }

        public List<UniversityType> GetList(Expression<Func<UniversityType, bool>> filter = null)
        {
            var universityTypes = universityTypeDal.GetList(filter);
            return universityTypes;
        }

        public void Update(UniversityType entity)
        {
            universityTypeDal.Update(entity); 
        }
    }
}
