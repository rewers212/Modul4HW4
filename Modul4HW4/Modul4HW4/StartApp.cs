using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Modul4HW4
{
    public class StartApp
    {
        private ContextFactory _optionBuilder = new ContextFactory();

        public void FirstQuery()
        {
            using (var dbContext = _optionBuilder.CreateDbContext(new string[0]))
            {
                var firstQuery = from employee in dbContext.Employees
                                 join employeeProject in dbContext.EmployeeProject
                                 on employee.EmployeeId equals employeeProject.EmployeeId into eep
                                 from subEmployeeProject in eep.DefaultIfEmpty()
                                 join project in dbContext.Projects
                                 on subEmployeeProject.EmployeeProjectId equals project.ProjectId into epp
                                 from subProject in epp.DefaultIfEmpty()
                                 select new
                                 {
                                     EmployeeName = employee.FirstName + " " + employee.LastName,
                                     HiredDate = employee.HiredDate,
                                     DateOfBirth = employee.DateOfBirth,
                                     EmployeeProjectRate = subEmployeeProject.Rate,
                                     EmployeeProjectStartDate = subEmployeeProject.StartedDate,
                                     ProjectName = subProject.Name,
                                     ProjectBudget = subProject.Budget,
                                     ProjectStartedDate = subProject.StartedDate
                                 };

                firstQuery.ToList();
            }
        }

        public void SecondQuery()
        {
            using (var dbContext = _optionBuilder.CreateDbContext(new string[0]))
            {
                var employees = dbContext.Employees
                    .Select(x => new
                    {
                        FullName = x.FirstName + " " + x.LastName,
                        MonthsOfWork = EF.Functions.DateDiffMonth(x.HiredDate, DateTime.Today)
                    }).ToList();
            }
        }

        public void ThirdQuery()
        {
            using (var dbContext = _optionBuilder.CreateDbContext(new string[0]))
            {
                var emp = dbContext.Employees.Find(1);
                emp.OfficeId = 3;
                dbContext.Update(emp);

                var office = dbContext.Offices.Find(1);
                office.Location = "sidney";
                dbContext.Update(office);

                dbContext.SaveChanges();
            }
        }

        public void FourthQuery()
        {
            using (var dbContext = _optionBuilder.CreateDbContext(new string[0]))
            {
                dbContext.Employees.Add(
                    new Employee
                    {
                        FirstName = "ivan",
                        LastName = "kardan",
                        HiredDate = new DateTime(2017, 1, 20),
                        DateOfBirth = new DateTime(1946, 6, 14),
                        Title = new Title
                        {
                            Name = "Billionaire"
                        },
                        OfficeId = 1
                    });

                dbContext.SaveChanges();

                var newEmployeeProject = new EmployeeProject
                {
                    Rate = 50000m,
                    StartedDate = new DateTime(2001, 11, 11),
                    EmployeeId = 4,
                    ProjectId = 3
                };

                dbContext.EmployeeProject.Add(newEmployeeProject);

                dbContext.SaveChanges();
            }
        }

        public void FifthQuery()
        {
            using (var dbContext = _optionBuilder.CreateDbContext(new string[0]))
            {
                var employee = dbContext.Employees.FirstOrDefault(x => x.LastName.Equals("Nzinga"));
                dbContext.Employees.Remove(employee);
                dbContext.SaveChanges();
            }
        }

        public void SixthQuery()
        {
            using (var dbContext = _optionBuilder.CreateDbContext(new string[0]))
            {
                var eployees = dbContext.Employees
                    .Select(x => new
                    {
                        Title = x.Title.Name
                    }).Where(x => !EF.Functions.Like(x.Title, "%a%"))
                    .GroupBy(x => x.Title)
                    .Select(x => new
                    {
                        Title = x.Key,
                        Count = x.Count()
                    }).ToList();
            }
        }
    }
}
