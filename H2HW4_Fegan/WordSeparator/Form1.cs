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
* 09/11/2021
* CSC 253
* Zachary Fegan
* This application will take a sentence that the words run together and separates each word to make a sentence.
*/

namespace WordSeparator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unscrableButton_Click(object sender, EventArgs e)
        {
            // Get the user's input
            string sentence = sentenceTextBox.Text;
            // Used to hold the index of an uppercase letter
            int upperCase;

            foreach (char up in sentence)
            {

                if (char.IsUpper(up))
                {
                    // Find the index of the uppercase letter
                    upperCase = sentence.IndexOf(up);
                    // Used to add a space at the appropriate index
                    sentence = sentence.Insert(upperCase, "");
                }
            }
            // Make all the letters lowercase
            sentence = sentence.ToLower();
            // Capitalize the first letter of the sentence.
            sentence = sentence[1].ToString().ToUpper() + sentence.Substring(2);

            // Display the output of the user's input
            outputLabel.Text = sentence;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            sentenceTextBox.Text = "";
            outputLabel.Text = "";

            sentenceTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
