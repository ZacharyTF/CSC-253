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
* 08-18-2021
* CSC 253
* Zachary Fegan
* This program will calculate an object's kinetic energy, and it will display that information to the user.
*/

namespace M1HW2_Fegan
{
    public partial class KE_Cal_Form : Form
    {
        public KE_Cal_Form()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // These variables will hold each the object's mass, velocity, and its kinetic energy.
            double mass, velocity, kinEnergy;

            // This will translate what text the user had entered into the mass textbox into numerical data.
            if(double.TryParse(massTextBox.Text, out mass))
            {
                // This will translate what text the user had entered into the velocity textbox into numerical data.
                if (double.TryParse(velocityTextBox.Text, out velocity))
                {
                    // Will calculate the fomula in a value-returning method.
                    kinEnergy = getKineticEnergy(mass, velocity);

                    // This will put the results into a label box that the user cannot edit.
                    kinEnergyLabelBox.Text = kinEnergy.ToString();
                }
                else
                {
                    // Display to the user to enter a number that is valid.
                    MessageBox.Show("Enter a vaild number.");
                }
            }
            else
            {
                // Display to the user to enter a number that is valid.
                MessageBox.Show("Enter a vaild number.");
            }
        }

        // This is where the formula will be calculated.
        private double getKineticEnergy(double mass, double velocity)
        {
            // This formula is used to calculate the object's Kinetic Energy.
            // This will also return the 
            return 0.5 * mass * (velocity * velocity);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // This is to clear any text/input that is contained in these boxes
            massTextBox.Text = "";
            velocityTextBox.Text = "";
            kinEnergyLabelBox.Text = "";

            // When the user clicks the clear button it will take the user back to
            // the first text box.
            massTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // This is used to close this form
            this.Close();
        }
    }
}
