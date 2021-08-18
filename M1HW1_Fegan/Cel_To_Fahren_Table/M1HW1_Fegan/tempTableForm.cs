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
* 08-17-2021
* CSC 253
* Zachary Fegan
* This program will display a table that converts different Celsius temperatures into their Fahrenheit equivalents temperatures.
*/

namespace M1HW1_Fegan
{
    public partial class tempTableForm : Form
    {
        public tempTableForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // These variables will hold their values when iterating through the while loop.
            int cel = 0;
            decimal fahren;

            // This while loop will iterate Celsius temperatures 0 through 20.
            while (cel <= 20)
            {
                // This is the formula that will calculate the celsius temperatures to their fahrenheit equivalents temperatures.
                fahren = ((9 / 5) * cel) + 32;

                // This will display the items to the user via list box.
                tempConvertListBox.Items.Add("Celsius: " + cel + "                " +
                                             "Fahrenheit: " + fahren);

                // Used to incriment Celsius variables.
                cel++;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // This is to close the form.
            this.Close();
        }
    }
}
