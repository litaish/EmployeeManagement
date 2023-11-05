using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    [Serializable]
    public class Project
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public BindingList<Task> Tasks { get; set; }
        public Company Company { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
