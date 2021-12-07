using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuitionLibrary;

/**
* 11/15/2021
* CSC 253
* Zachary Fegan
* This program is the unit testing for the Tuition Increase Application
*/

namespace UnitTuitionIncrease
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTuitionButton_Click(object sender, EventArgs e)
        {
            double tuition;
            double percentIncrease;
            int years;

            if (double.TryParse(tuitionTextBox.Text, out tuition))
            {
                if (double.TryParse(increaseTextBox.Text, out percentIncrease))
                {
                    double percent = percentIncrease / 100;
                    if (int.TryParse(yearsTextBox.Text, out years))
                    {
                        projectedOutputListBox.Items.Add(Calculate.CalculateTuition(tuition, percent, years));
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid number of years!");
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid percent rate of increase!");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid price for tuition!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
