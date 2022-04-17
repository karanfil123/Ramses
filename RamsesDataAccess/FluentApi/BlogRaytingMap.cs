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
    public class BlogRaytingMap : IEntityTypeConfiguration<BlogRayting>
    {
        public void Configure(EntityTypeBuilder<BlogRayting> builder)
        {
            builder.HasKey(x => x.B_RaytingID);
            builder.Property(x => x.B_RaytingID).ValueGeneratedOnAdd().IsRequired();
        }
    }
}
