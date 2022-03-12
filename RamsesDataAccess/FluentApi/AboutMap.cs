using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RamsesEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesDataAccess.FluentApi
{
    public class AboutMap : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {            
            builder.Property(x => x.Detail1).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.Detail2).HasMaxLength(5000).IsRequired();
            builder.Property(x => x.Image1).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Image2).HasMaxLength(250).IsRequired();
            builder.Property(x => x.MapLocation).HasMaxLength(500).IsRequired();

            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.CreateByName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.ToTable("Abouts");
        }
    }
}
