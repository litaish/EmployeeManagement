using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EmployeeManagement
{
    [Serializable]
    public class Company
    {
        public string Name { get; set; }
        public BindingList<Employee> Employees { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
