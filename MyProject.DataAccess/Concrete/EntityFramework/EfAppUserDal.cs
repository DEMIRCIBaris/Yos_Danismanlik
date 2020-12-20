using Microsoft.EntityFrameworkCore;
using MyProject.DataAccess.Abstract;
using MyProject.DataAccess.Concrete.EntityFramework.Context;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework
{
    public class EfAppUserDal : IAppUserDal
    {
        public List<University> GetUniversityListByStudentId(int studentId)
        {
            using (var dB=new MyDataContext())
            {
                var universities = dB.Users.Include(i => i.Universities).FirstOrDefault(i => i.Id == studentId).Universities;
                return universities;
            }
        }
    }
}
