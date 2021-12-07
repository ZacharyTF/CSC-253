using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5HW1_Fegan
{
    class Employee
    {
        // Employee Constructor
        public Employee()
        {
            EmployeeName = "";
            ShiftNumber = 0;
            HourlyPayRate = 0;
        }

        // Employee Properties
        public string EmployeeName { get; set; }
        public int ShiftNumber { get; set; }
        public decimal HourlyPayRate { get; set; }
    }
}
