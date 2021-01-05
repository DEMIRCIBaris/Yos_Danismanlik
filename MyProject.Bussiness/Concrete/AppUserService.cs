using MyProject.Bussiness.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.Concrete
{
    public class AppUserService : IAppUserService
    {
        private readonly IAppUserDal appUserDal;

        public AppUserService(IAppUserDal appUserDal)
        {
            this.appUserDal = appUserDal;
        }
        
        public List<University> GetUniversityListByStudentId(int studentId)
        {
            var universities = appUserDal.GetUniversityListByStudentId(studentId);
            return universities;
        }

        public int UserCount()
        {
            return appUserDal.UserCount();
        }
    }
}
