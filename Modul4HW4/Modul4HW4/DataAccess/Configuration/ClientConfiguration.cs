using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modul4HW4
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(p => p.ClientId);
            builder.Property(p => p.ClientId).HasColumnName("ClientId").ValueGeneratedOnAdd();
            builder.Property(p => p.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(p => p.Country).IsRequired().HasColumnName("Country").HasMaxLength(50);
            builder.Property(p => p.DateOfBirth).HasColumnName("DateOfBirth").HasColumnType("date");

            builder.HasData(
                new Client
                {
                    ClientId = 1,
                    FirstName = "Tom",
                    LastName = "Hanks",
                    Country = "USA",
                    DateOfBirth = new DateTime(1999, 11, 11)
                },
                new Client
                {
                    ClientId = 1,
                    FirstName = "Britny",
                    LastName = "Spirs",
                    Country = "China",
                    DateOfBirth = new DateTime(2000, 11, 11)
                });
        }
    }
}
