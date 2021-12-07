using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamLeaderClassLibrary;

/**
* 10-27-2021
* CSC 253
* Zachary Fegan
* This program will demonstrate how to make an object with derived from different classes
*/

namespace TeamLeader_Class
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
            if (int.TryParse(shiftNumberTextBox.Text, out shiftNumber))
            {
                // Set the input from the user to shift number
                account.ShiftNumber = shiftNumber;

                // Get and parse the input for hourly pay rate
                if (decimal.TryParse(hourlyPayRateTextBox.Text, out hourlyPayRate))
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

        private void GetTeamLeaderInfo(TeamLeader leader)
        {
            // Temporary variables
            decimal monthlyBonus;
            double requiredHours;
            double attendedHours;

            // Get and parse the input from the user for the monthly bonus
            if (decimal.TryParse(monthlyBonusTextBox.Text, out monthlyBonus))
            {
                // Set the input from the user to monthly bonus
                leader.MonthlyBonus = monthlyBonus;

                // Get and parse the input from the user to required hours
                if (double.TryParse(requiredHoursTextBox.Text, out requiredHours))
                {
                    // Set the input from the user to requiredHours
                    leader.RequiredHours = requiredHours;

                    // Get and parse the input from the user to attendedHours
                    if (double.TryParse(numberOfHoursAttendedTextBox.Text, out attendedHours))
                    {
                        // Set the input from the user to attendedHours
                        leader.AttendedHours = attendedHours;
                    }
                    else
                    {
                        // Display that there was an invalid number of hours to the user
                        MessageBox.Show("Invalid Number of Hours!");
                    }
                }
                else
                {
                    // Display that there was an invalid number of hours to the user
                    MessageBox.Show("Invalid Number of Hours!");
                }
            }
            else
            {
                // Display that there was an invalid amount for the monthly bonus to the user
                MessageBox.Show("Invalid monthly bonus!");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            ProductionWorker myAccount = new ProductionWorker();
            TeamLeader myLeader = new TeamLeader();

            GetEmployeeInfoData(myAccount);
            GetTeamLeaderInfo(myLeader);

            // Display info to the user
            employeeNameLabel.Text = myAccount.EmployeeName;
            employeeNumberLabel.Text = myAccount.EmployeeNumber;
            shiftNumberLabel.Text = myAccount.ShiftNumber.ToString();
            hourlyPayRateLabel.Text = myAccount.HourlyPayRate.ToString("c");
            monthlyBonusLable.Text = myLeader.MonthlyBonus.ToString("c");
            requiredTrainingHoursLabel.Text = myLeader.RequiredHours.ToString();
            numberofHoursAttendedLabel.Text = myLeader.AttendedHours.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // This closes the form
            this.Close();
        }
    }
}
