using MyProject.Bussiness.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using System.Collections.Generic;

namespace MyProject.Bussiness.Concrete
{
    public class AppUserService : IAppUserService
    {
        private readonly IAppUserDal appUserDal;

        public AppUserService(IAppUserDal appUserDal)
        {
            this.appUserDal = appUserDal;
        }

        public void DeleteUserUniversity(int userId, int universityId)
        {
            appUserDal.DeleteUserUniversity(userId,universityId);
        }

        public List<AppUser> GetList()
        {
            return appUserDal.GetList();
        }

        public List<University> GetUniversityListByStudentId(int studentId)
        {
            var universities = appUserDal.GetUniversityListByStudentId(studentId);
            return universities;
        }

        public AppUser GetUserWithUniversities(int userId)
        {
            return appUserDal.GetUserWithUniversities(userId);
        }

        public void Update(AppUser appUser)
        {
            appUserDal.Update(appUser); 
        }

        public int UserCount()
        {
            return appUserDal.UserCount();
        }
    }
}
