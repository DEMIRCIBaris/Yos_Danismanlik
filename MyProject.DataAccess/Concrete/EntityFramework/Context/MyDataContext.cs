using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyProject.DataAccess.Concrete.EntityFramework.Mapping;
using MyProject.Entities.Concrete.IdentityLibraryEntites;

namespace MyProject.DataAccess.Concrete.EntityFramework.Context
{
    public class MyDataContext: IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=WorkFlowDB;Server=(localdb)\MSSQLLocalDB;Trusted_Connection=True;"); //Connection String eklendi
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserMap());
            base.OnModelCreating(builder);
        }

    }
}
