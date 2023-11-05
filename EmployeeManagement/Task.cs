using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EmployeeManagement
{
    [Serializable]
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int EstimatedTime { get; set; }
        public BindingList<TaskTime> TaskTimes { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
