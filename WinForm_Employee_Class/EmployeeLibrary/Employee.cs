using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        public Employee(string name, int id, string depart, string post)
        {
            EmployeeName = name;
            EmployeeNumber = id;
            EmployeeDepartment = depart;
            EmployeePosition = post;
        }

        public string EmployeeName { get; set; }
        public int EmployeeNumber { get; set; }
        public string EmployeeDepartment { get; set; }
        public string EmployeePosition { get; set; }

        public Employee()
        {
            EmployeeName = "";
            EmployeeNumber = 0;
            EmployeeDepartment = "";
            EmployeePosition = "";
        }

        public override string ToString()
        {
            return "Employee Name: " + EmployeeName + "\r\n" +
                   "Employee Id: " + EmployeeNumber + "\r\n" +
                   "Employee Department: " + EmployeeDepartment + "\r\n" +
                   "Employee Position: " + EmployeePosition + "\r\n";
        }
    }
}
