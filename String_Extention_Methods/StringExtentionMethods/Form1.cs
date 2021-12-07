using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionMethodsLibrary;

/**
* 11/1/2021
* CSC 253
* Zachary Fegan
* This program will use different extension methods and demonstrate how to uses them in an application
*/

namespace StringExtentionMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertionDateButton_Click(object sender, EventArgs e)
        {
            // Get the input from the user
            string input = dateFormatTextBox.Text;
            // Display the converted output to the user
            outputConvertedDateLabel.Text = input.DateExtension();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // This closes the form
            this.Close();
        }

        private void formatPhoneNumberButton_Click(object sender, EventArgs e)
        {
            // Get the input from the user
            string userPhone = userPhoneNumberTextBox.Text;
            // Display the formatted phone number to the user
            outputFormatedPhoneNumberLabel.Text = userPhone.IsAPhoneNumber();
        }

        private void reverseTextButton_Click(object sender, EventArgs e)
        {
            // Get the input from the user
            string userText = reverseTextBox.Text;
            // Display the reversed text to the user
            outputReverseTextLabel.Text = userText.ReverseInput();
        }

        private void countWordsButton_Click(object sender, EventArgs e)
        {
            // Get the input from the user
            string userText = inputWordsTextBox.Text;
            // Display the number of words the user has entered
            outputNumberOfWordsLabel.Text = userText.CountText();
        }
    }
}
