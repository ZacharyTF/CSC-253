using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamLeaderClassLibrary
{
    public abstract class Employee
    {
        public Employee()
        {
            EmployeeName = "";
            ShiftNumber = 0;
            HourlyPayRate = 0;
        }

        // Employee Constructor
        public Employee(string employeeName, int shiftNumber, decimal hourlyPayRate)
        {
            EmployeeName = employeeName;
            ShiftNumber = shiftNumber;
            HourlyPayRate = hourlyPayRate;
        }

        // Employee Properties
        public string EmployeeName { get; set; }
        public int ShiftNumber { get; set; }
        public decimal HourlyPayRate { get; set; }
    }
}
