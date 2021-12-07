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
* 10-22-2021
* CSC 253
* Zachary Fegan
* This program will demonstrate how to create objects using different classes
*/

namespace M5HW2_Fegan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetEmployeeInfoData(ShiftSupervisor account)
        {
            // Temporary variables
            int shiftNumber;
            decimal hourlyPayRate;
            decimal annualSalary;
            decimal annualProductionBonus;

            // Get the employee's name from the user
            account.EmployeeName = employeeNameTextBox.Text;

            // Get the employee's number from the user
            account.EmployeeNumber = employeeNumberTextBox.Text;

            // Get and parse the input from the user to shift number
            if (int.TryParse(shiftNumberTextBox.Text, out shiftNumber))
            {
                // Set the input from the user to shift number
                account.ShiftNumber = shiftNumber;

                // Get and parse the input for hourly pay rate
                if (decimal.TryParse(hourlyPayRateTextBox.Text, out hourlyPayRate))
                {
                    // Set the input from the user to hourly pay rate
                    account.HourlyPayRate = hourlyPayRate;

                    // Get and parse the input for the annual salary
                    if (decimal.TryParse(annualSalaryTextBox.Text, out annualSalary))
                    {
                        // Set the input from the user to annualSalary 
                        account.AnnualSalary = annualSalary;

                        // Get and parse the input for the annual production bonus
                        if (decimal.TryParse(annualProductionBonusTextBox.Text, out annualProductionBonus))
                        {
                            // Set the input from the user to annualProductionBonus
                            account.AnnualProductionBonus = annualProductionBonus;
                        }
                        else
                        {
                            // Display to the user that the input for the Production bonus was invalid
                            MessageBox.Show("Invalid Bonus!");
                        }
                    }
                    else
                    {
                        // Display to the user that the input for the annual Salary was invalid
                        MessageBox.Show("Invalid Salary!");
                    }
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
            ShiftSupervisor myAccount = new ShiftSupervisor(); 

            // Call the method
            GetEmployeeInfoData(myAccount);

            // Display info to the user
            employeeNameLabel.Text = myAccount.EmployeeName;
            employeeNumberLabel.Text = myAccount.EmployeeNumber;
            shiftNumberLabel.Text = myAccount.ShiftNumber.ToString();
            hourlyPayRateLabel.Text = myAccount.HourlyPayRate.ToString("c");
            annualSalaryLabel.Text = myAccount.AnnualSalary.ToString("c"); ;
            annualProductionBonusLabel.Text = myAccount.AnnualProductionBonus.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // This closes the form
            this.Close();
        }
    }
}
