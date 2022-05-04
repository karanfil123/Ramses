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
    public class AdminMap : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Username).HasMaxLength(40).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(40).IsRequired();
            builder.Property(x => x.NameSurname).HasMaxLength(40).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(400).IsRequired();
            builder.Property(x => x.ImageUrl).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Role).HasMaxLength(40).IsRequired();
            builder.HasData(new Admin
            {
                ID = 1,
                Username = "bulent",
                Password = "111",
                NameSurname = "Bülent Karanfil",
                Description = " A adlı TV sisteminde yayımlandı. Dizi TV sisteminde yayımlandı.",
                ImageUrl = "https://t3.ftcdn.net/jpg/00/07/32/48/360_F_7324855_mx4CEBWTr81XLOrlQccCROtP2uNR7xbk.jpg",
                Role = "Admin"
            }, new Admin
            {
                ID = 2,
                Username = "bulent2",
                Password = "111",
                NameSurname = "Bülent Karanfil2",
                Description = " A adlı TV sisteminde yayımlandı. Dizi TV sisteminde yayımlandı.",
                ImageUrl = "https://t3.ftcdn.net/jpg/00/07/32/48/360_F_7324855_mx4CEBWTr81XLOrlQccCROtP2uNR7xbk.jpg",
                Role = "Admin2"
            });
        }
    }
}
