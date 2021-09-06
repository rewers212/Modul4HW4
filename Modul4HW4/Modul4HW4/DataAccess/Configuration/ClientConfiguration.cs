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
                    FirstName = "Ivan",
                    LastName = "Kardan",
                    DateOfBirth = new DateTime(1943, 2, 18),
                    Country = "USA"
                },
                new Client
                {
                    ClientId = 2,
                    FirstName = "Yan",
                    LastName = "Gus",
                    DateOfBirth = new DateTime(1993, 9, 8),
                    Country = "USSR"
                },
                new Client
                {
                    ClientId = 3,
                    FirstName = "Roberto",
                    LastName = "Ravioly",
                    DateOfBirth = new DateTime(1977, 12, 18),
                    Country = "Italy"
                },
                new Client
                {
                    ClientId = 4,
                    FirstName = "Daniel",
                    LastName = "Taxi",
                    DateOfBirth = new DateTime(2000, 8, 20),
                    Country = "France"
                },
                new Client
                {
                    ClientId = 5,
                    FirstName = "Tom",
                    LastName = "Dom",
                    DateOfBirth = new DateTime(1934, 2, 10),
                    Country = "England"
                });
        }
    }
}
