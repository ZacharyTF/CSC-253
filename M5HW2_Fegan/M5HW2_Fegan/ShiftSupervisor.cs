using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5HW2_Fegan
{
    class ShiftSupervisor : Employee
    {
        // Constructor for the shifts supervisor
        public ShiftSupervisor()
        {
            EmployeeNumber = "";
            AnnualSalary = 0;
            AnnualProductionBonus = 0;
        }

        // Properties for the Annual salary and production bonuses
        public string EmployeeNumber { get; set; }
        public decimal AnnualSalary { get; set; }
        public decimal AnnualProductionBonus { get; set; }
    }
}
