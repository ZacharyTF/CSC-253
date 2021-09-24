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
* 09-5-2021
* CSC 253
* Zachary Fegan
* This program will demonstrate how to count and average how many words the user inputs in the text box.
*/

namespace M2HW2_Fegan
{
    public partial class averageWordForm : Form
    {
        public averageWordForm()
        {
            InitializeComponent();
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            // Get input from the user and pass to method.
            var wordCount = averageWordLetter(wordTextBox.Text);
            // Display the average to the user.
            averageLabel.Text = wordCount.ToString();
        }

        private double averageWordLetter(string input)
        {
            // This will remove any whitespace.
            var separators = new[] { ' ', '.' };
            // This will caculate how may letters per word
            var average = input.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>x.Length).Average();
            // return average to be displayed to the user.
            return average;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // this closes the form.
            this.Close();
        }
    }
}
