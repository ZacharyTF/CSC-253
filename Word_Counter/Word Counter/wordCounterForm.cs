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
* 09-04-2021
* CSC 253
* Zachary Fegan
* This program will count how many words the user types in the textbox.
*/

namespace Word_Counter
{
    public partial class wordCounterForm : Form
    {
        public wordCounterForm()
        {
            InitializeComponent();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            // used to gather input from the user
            string whole_text = wordTextBox.Text;
            // This removes any leading spaces and/or trailing spaces
            string trimmed_text = whole_text.Trim();
            // this tokenizes the trimmed text
            string[] split_text = trimmed_text.Split(' ');
            // A variable used to count how many words there are.
            int space_count = 0;
            //
            string new_text = "";

            //
            foreach(string av in split_text)
            {
                // used an if loop to count the words from the user.
                if(av == "")
                {
                    // used to count the words in the text box
                    space_count++;
                }
                else
                {
                    //
                    new_text = new_text + av + ",";
                }
            }
            //
            new_text = new_text.TrimEnd(',');
            //
            split_text = new_text.Split(',');
            // Used to display how many words were counted to the user
            counterLabel.Text = split_text.Length.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // this closes the form.
            this.Close();
        }
    }
}
