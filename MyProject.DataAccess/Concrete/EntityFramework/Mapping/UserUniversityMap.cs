using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserUniversityMap : IEntityTypeConfiguration<UserUniversity>
    {
        public void Configure(EntityTypeBuilder<UserUniversity> builder)
        {
            builder.HasKey(usun => new { usun.UsersId, usun.UniversitiesId });
            builder.HasOne(bc => bc.AppUser).WithMany(b => b.UsersUniversities).HasForeignKey(bc => bc.UsersId);
            builder.HasOne(bc => bc.University).WithMany(b => b.UsersUniversities).HasForeignKey(bc => bc.UniversitiesId);
        }
    }
}
