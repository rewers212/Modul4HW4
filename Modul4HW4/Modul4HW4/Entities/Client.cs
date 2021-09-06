using System;
using System.Collections.Generic;

namespace Modul4HW4
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
