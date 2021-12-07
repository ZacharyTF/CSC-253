using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamLeaderClassLibrary
{
    public class ProductionWorker : Employee
    {
        public ProductionWorker()
        {
            EmployeeNumber = "";
        }

        // Constructor for the information for the ProductionWorker
        public ProductionWorker(string employeeName, int shiftNumber, decimal hourlyPayRate, string employeeNumber) : base (employeeName, shiftNumber, hourlyPayRate)
        {
            EmployeeNumber = employeeNumber;
        }

        // Properties
        public string EmployeeNumber { get; set; }
    }
}
