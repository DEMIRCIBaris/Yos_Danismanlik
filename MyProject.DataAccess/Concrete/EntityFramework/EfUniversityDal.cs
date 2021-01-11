using Microsoft.EntityFrameworkCore;
using MyProject.Core.DataAccess.EntityFramework;
using MyProject.DataAccess.Abstract;
using MyProject.DataAccess.Concrete.EntityFramework.Context;
using MyProject.Entities.Concrete;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework
{
    public class EFUniversityDal : EfEntityRepositoryBase<MyDataContext, University>, IUniversityDal
    {
        public List<AppUser> GetUniversitiesUsers(int universityId)
        {
            using(var dB=new MyDataContext())
            {
                var university = dB.Universities.Include(i => i.UsersUniversities).ThenInclude(i => i.AppUser).FirstOrDefault(i => i.Id == universityId);
                return university.UsersUniversities.Select(i => i.AppUser).ToList();
               
            }
        }

        public List<University> GetUniversityWithCityAndType()
        {
            using (var dB=new MyDataContext())
            {

                var universities =  dB.Universities.Include(i => i.City).Include(i => i.UniversityType).ToList();

                return universities;
            }
        }

        public List<University> GetUniversityWithCityAndType(string search)
        {
            using (var dB = new MyDataContext())
            {
                var universities = new List<University>();

                if (!string.IsNullOrEmpty(search))
                     universities = dB.Universities.Include(i => i.City).Include(i => i.UniversityType).Where(i=>(i.City.Name.ToLower().Contains(search)) || (i.Name.ToLower().Contains(search))).ToList();
                else 
                     universities = dB.Universities.Include(i => i.City).Include(i => i.UniversityType).ToList();

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
