using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modul4HW4
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.EmployeeProjectId);
            builder.Property(e => e.EmployeeProjectId).HasColumnName("EmployeeProjectId").ValueGeneratedOnAdd();
            builder.Property(e => e.Rate).IsRequired().HasColumnName("Rate").HasColumnType("money");
            builder.Property(e => e.StartedDate).IsRequired().HasColumnName("StartedDate").HasColumnType("datetime2").HasMaxLength(7);
            builder.Property(e => e.EmployeeId).IsRequired().HasColumnName("EmployeeId");
            builder.Property(e => e.ProjectId).IsRequired().HasColumnName("ProjectId");
            builder.HasOne(ep => ep.Employee)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(ep => ep.Project)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(e => e.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new EmployeeProject
                {
                    EmployeeProjectId = 1,
                    Rate = 1000m,
                    StartedDate = new DateTime(1999, 11, 11, 11, 30, 22),
                    EmployeeId = 1,
                    ProjectId = 1
                },
                new EmployeeProject
                {
                    EmployeeProjectId = 2,
                    Rate = 2000m,
                    StartedDate = new DateTime(1777, 7, 1, 11, 22, 11),
                    EmployeeId = 2,
                    ProjectId = 2
                });
        }
    }
}
