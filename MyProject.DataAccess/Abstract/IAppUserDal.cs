using MyProject.Entities.Concrete;
using MyProject.Entities.Concrete.IdentityLibraryEntites;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Abstract
{
    public interface IAppUserDal
    {
        List<University> GetUniversityListByStudentId(int studentId);
        int UserCount();
    }
}
