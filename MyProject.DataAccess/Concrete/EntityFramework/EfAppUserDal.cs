using Microsoft.EntityFrameworkCore;
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
    public class EfAppUserDal : IAppUserDal
    {
        public void DeleteUserUniversity(int userId, int universityId)
        {
            using (var dB = new MyDataContext())
            {
                var userUniversity = dB.UsersUniversities.FirstOrDefault(i => i.UsersId == userId && i.UniversitiesId == universityId);
                dB.UsersUniversities.Remove(userUniversity);
                dB.SaveChanges();
            }
        }

        public List<AppUser> GetList()
        {
            using (var dB = new MyDataContext())
            {
                var adminIDs = dB.Roles.Where(i => i.Name == "Admin").Select(i => i.Id).FirstOrDefault();
                var userIDs = dB.UserRoles.Where(i => i.RoleId != adminIDs).Select(i => i.UserId).ToList();
                var users = new List<AppUser>();
                foreach (var id in userIDs)
                {
                    var user = dB.Users.Find(id);
                    users.Add(user);
                }
                return users;
                
            }
        }

        public List<University> GetUniversityListByStudentId(int studentId)
        {
            using (var dB=new MyDataContext())
            {
                var universities = dB.Users.Include(i => i.UsersUniversities).FirstOrDefault(i => i.Id == studentId).UsersUniversities.Select(i=>i.University).ToList();
                return universities;
            }
        }

        public AppUser GetUserWithUniversities(int userId)
        {
            using (var dB = new MyDataContext())
            {
                var user = dB.Users.Include(i => i.UsersUniversities).ThenInclude(i=>i.University).FirstOrDefault(i => i.Id == userId);
                return user;
            }
        }

        public void Update(AppUser appUser)
        {
            using (var dB= new MyDataContext())
            {
                dB.Users.Update(appUser);
                dB.SaveChanges();
            }
        }

        public int UserCount()
        {
            using (var dB = new MyDataContext())
            {
                var adminIDs = dB.Roles.Where(i => i.Name == "Admin").Select(i => i.Id).FirstOrDefault();
                var userIDs = dB.UserRoles.Where(i => i.RoleId != adminIDs).Select(i => i.UserId).ToList();

                return userIDs.Count();
            }
        }
    }
}
