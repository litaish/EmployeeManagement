using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    [Serializable]
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
