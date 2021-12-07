using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamLeaderClassLibrary
{
    class TeamLeader : ProductionWorker
    {
        // Default constructor
        public TeamLeader()
        {
            MonthlyBonus = 0;
            RequiredHours = 0;
            AttendedHours = 0;
        }

        // TeamLeader constructor
        public TeamLeader(string employeeName, int shiftNumber, decimal hourlyPayRate, string employeeNumber, decimal monthlyBonus, double requiredHours, double attendedHours) 
            : base (employeeName, shiftNumber, hourlyPayRate, employeeNumber)
        {
            MonthlyBonus = monthlyBonus;
            RequiredHours = requiredHours;
            AttendedHours = attendedHours;
        }

        // TeamLeader Properties
        public decimal MonthlyBonus { get; set; }
        public double RequiredHours { get; set; }
        public double AttendedHours { get; set; }
    }
}
