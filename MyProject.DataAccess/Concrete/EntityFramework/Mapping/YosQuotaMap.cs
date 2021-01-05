using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class YosQuotaMap : IEntityTypeConfiguration<YosQuota>
    {
        public void Configure(EntityTypeBuilder<YosQuota> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.UniversityName).HasMaxLength(300).IsRequired();
            builder.Property(i => i.Time).HasMaxLength(10).IsRequired();
            builder.Property(i => i.Quota).HasMaxLength(10).IsRequired();
        }
    }
}
