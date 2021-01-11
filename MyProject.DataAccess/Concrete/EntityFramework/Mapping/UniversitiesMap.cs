using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UniversitiesMap : IEntityTypeConfiguration<University>
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {
            builder.HasKey(i=>i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.Name).HasMaxLength(300).IsRequired();
            builder.HasOne(i => i.City).WithMany(i=>i.Universities).HasForeignKey(i=>i.CityId);
            builder.HasOne(i => i.UniversityType).WithMany(i => i.Universities).HasForeignKey(i => i.UniversityTypeId);
        }
    }
}
