using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    [Serializable]
    public class TaskTime
    {
        public Employee Employee { get; set; }
        public TimeSpan Time { get; set; }
    }
}
