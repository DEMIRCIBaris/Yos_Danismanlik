using MyProject.Entities.Concrete;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using System.Collections.Generic;

namespace MyProject.DataAccess.Abstract
{
    public interface IAppUserDal
    {
        List<University> GetUniversityListByStudentId(int studentId);
        int UserCount();
        List<AppUser> GetList();
        void Update(AppUser appUser);
        AppUser GetUserWithUniversities(int userId);
        void DeleteUserUniversity(int userId, int universityId);
    }
}
