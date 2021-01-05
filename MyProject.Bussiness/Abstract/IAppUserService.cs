using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.Abstract
{
    public interface IAppUserService
    {
        List<University> GetUniversityListByStudentId(int studentId);
        int UserCount();
    }
}
