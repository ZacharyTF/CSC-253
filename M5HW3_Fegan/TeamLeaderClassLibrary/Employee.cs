using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamLeaderClassLibrary
{
    public abstract class Employee
    {
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

        public abstract string ;
    }
}
