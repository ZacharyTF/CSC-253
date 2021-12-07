using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeLibrary;

/**
* 11/22/2021
* CSC 253
* Zachary Fegan
* This is the WinForm for the EmployeeClass assignment
*/

namespace WinFormEmployeeClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayInfoButton_Click(object sender, EventArgs e)
        {
            string name = employeeNameTextBox.Text;
            int id = Convert.ToInt32(idNumberTextBox.Text);
            string depart = departmentTextBox.Text;
            string post = positionTextBox.Text;

            Employee employee = new Employee(name, id, depart, post);
            employeeInfoTextBox.Text = employee.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            employeeNameTextBox.Text = "";
            idNumberTextBox.Text = "0";
            departmentTextBox.Text = "";
            positionTextBox.Text = "";

            employeeNameTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}