using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class YosQuestionsMap : IEntityTypeConfiguration<YosQuestions>
    {
        public void Configure(EntityTypeBuilder<YosQuestions> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.Name).HasMaxLength(300).IsRequired();
        }
    }
}
