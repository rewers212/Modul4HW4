using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW4
{
    public class EmployeeProject
    {
        public int EmployeeProjectId { get; set; }
        public decimal Rate { get; set; }
        public DateTime? StartedDate { get; set; }
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
