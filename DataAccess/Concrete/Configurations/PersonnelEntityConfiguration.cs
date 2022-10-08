using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Configurations
{
    public class PersonnelEntityConfiguration : IEntityTypeConfiguration<Personnel>
    {
        public void Configure(EntityTypeBuilder<Personnel> builder)
        {
            builder.HasKey(x => new { x.Id });
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.BirthDay);
            builder.Property(x => x.IdentityNumber).HasMaxLength(20).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
            builder.Property(x => x.FullAddress).HasMaxLength(300);
            builder.Property(x => x.AddressLine).HasMaxLength(200);
            builder.Property(x => x.CountryId);
            builder.Property(x => x.CityId);
            builder.Property(x => x.CountyId);
            builder.Property(x => x.NeighbourhoodId);
            builder.Property(x => x.ZipCode);
            builder.Property(x => x.ImagePath);
            builder.Property(x => x.IsUser);
            


        }
    }
}
