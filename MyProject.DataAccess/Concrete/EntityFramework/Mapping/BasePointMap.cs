using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class BasePointMap : IEntityTypeConfiguration<BasePoint>
    {
        public void Configure(EntityTypeBuilder<BasePoint> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i=>i.Department).HasMaxLength(100).IsRequired();
            builder.Property(i => i.FirstCities).HasMaxLength(10).IsRequired();
            builder.Property(i => i.SecondCities).HasMaxLength(10).IsRequired();
            builder.Property(i => i.ThirdCities).HasMaxLength(10).IsRequired();
        }
    }
}
