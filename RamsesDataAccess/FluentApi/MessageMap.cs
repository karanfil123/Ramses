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
    public class MessageMap : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Sender).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Receiver).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Subject).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
        }
    }
}
