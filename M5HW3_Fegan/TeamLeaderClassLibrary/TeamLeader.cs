using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamLeaderClassLibrary
{
    class TeamLeader : ProductionWorker
    {
        public TeamLeader(string employeeName, int shiftNumber, decimal hourlyPayRate, string employeeNumber, decimal monthlyBonus, double requiredHours, double attendedHours) 
            : base (employeeName, shiftNumber, hourlyPayRate, employeeNumber)
        {
            MonthlyBonus = monthlyBonus;
            RequiredHours = requiredHours;
            AttendedHours = attendedHours;
        }

        public decimal MonthlyBonus { get; set; }
        public double RequiredHours { get; set; }
        public double AttendedHours { get; set; }
    }
}
