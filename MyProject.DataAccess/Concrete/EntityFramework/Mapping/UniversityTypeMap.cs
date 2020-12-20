using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UniversityTypeMap : IEntityTypeConfiguration<UniversityType>
    {
        public void Configure(EntityTypeBuilder<UniversityType> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.Name).HasMaxLength(150);
            builder.HasMany(i => i.Universities).WithOne(i => i.UniversityType).HasForeignKey(i => i.UniversityTypeId);
        }
    }
}
