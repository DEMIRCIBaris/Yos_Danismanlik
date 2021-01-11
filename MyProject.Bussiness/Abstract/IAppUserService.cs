using MyProject.Entities.Concrete;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using System.Collections.Generic;

namespace MyProject.Bussiness.Abstract
{
    public interface IAppUserService
    {
        List<University> GetUniversityListByStudentId(int studentId);
        int UserCount();
        List<AppUser> GetList();
        void Update(AppUser appUser);
        AppUser GetUserWithUniversities(int userId);
        public void DeleteUserUniversity(int userId, int universityId);

    }
}
