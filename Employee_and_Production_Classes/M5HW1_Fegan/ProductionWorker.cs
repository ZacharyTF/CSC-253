using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5HW1_Fegan
{
    class ProductionWorker : Employee
    {
        // Constructor for the information for the ProductionWorker
        public ProductionWorker()
        {
            EmployeeNumber = "";
        }

        // Properties
        public string EmployeeNumber { get; set; }
    }
}
