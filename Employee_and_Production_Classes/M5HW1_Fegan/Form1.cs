using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* 10-25-2021
* CSC 253
* Zachary Fegan
* This program will demonstrate how to make an object with classes
*/

namespace M5HW1_Fegan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetEmployeeInfoData(ProductionWorker account)
        {
            // Temporary variables
            int shiftNumber;
            decimal hourlyPayRate;

            // Get the employee's name from the user
            account.EmployeeName = employeeNameTextBox.Text;

            // Get the employee's number from the user
            account.EmployeeNumber = employeeNumberTextBox.Text;

            // Get and parse the input from the user to shift number
            if(int.TryParse(shiftNumberTextBox.Text, out shiftNumber))
            {
                // Set the input from the user to shift number
                account.ShiftNumber = shiftNumber;

                // Get and parse the input for hourly pay rate
                if(decimal.TryParse(hourlyPayRateTextBox.Text, out hourlyPayRate))
                {
                    // Set the input from the user to hourly pay rate
                    account.HourlyPayRate = hourlyPayRate;
                }
                else
                {
                    //  Display that there was an invalid pay rate to the user
                    MessageBox.Show("Invalid pay rate!");
                }
            }
            else
            {
                // Display that there was an invalid shift number to the user
                MessageBox.Show("Invalid Shift Number!");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // Create the object
            ProductionWorker myAccount = new ProductionWorker();

            // Call the method
            GetEmployeeInfoData(myAccount);

            // Display info to the user
            employeeNameLabel.Text = myAccount.EmployeeName;
            employeeNumberLabel.Text = myAccount.EmployeeNumber;
            shiftNumberLabel.Text = myAccount.ShiftNumber.ToString();
            hourlyPayRateLabel.Text = myAccount.HourlyPayRate.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // This closes the form
            this.Close();
        }
    }
}
