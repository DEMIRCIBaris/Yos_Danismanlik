using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyProject.Core.Helpers.JsonHelpers;
using MyProject.DataAccess.Concrete.EntityFramework.Mapping;
using MyProject.Entities.Concrete;
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
            builder.ApplyConfiguration(new UniversitiesMap());
            builder.ApplyConfiguration(new CityMap());
            builder.ApplyConfiguration(new UniversityTypeMap());
            builder.ApplyConfiguration(new YosQuestionsMap());
            builder.ApplyConfiguration(new YosQuotaMap());
            builder.ApplyConfiguration(new BasePointMap());

            base.OnModelCreating(builder);
        }

        public DbSet<University> Universities { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<UniversityType> UniversityTypes { get; set; }
        public DbSet<YosQuestions> yosQuestions { get; set; }
        public DbSet<YosQuota> YosQuotas { get; set; }
        public DbSet<BasePoint> basePoints { get; set; }



    }
}
