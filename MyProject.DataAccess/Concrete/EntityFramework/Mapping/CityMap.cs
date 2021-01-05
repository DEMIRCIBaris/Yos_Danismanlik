using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Core.Helpers.JsonHelpers;
using MyProject.Entities.Concrete;
using MyProject.Entities.DTO.AppCityDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(i=>i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.Name).HasMaxLength(150);
            builder.HasMany(i => i.Universities).WithOne(i => i.City).HasForeignKey(i=>i.CityId); 
        }
    }
}
