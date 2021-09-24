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
* 09-09-2021
* CSC 253
* Zachary Fegan
* This program will allow a user to enter data and then display the character that appears the most frequently.
*/


namespace M2HW3_Fegan
{
    public partial class frequentWordFrom : Form
    {
        public frequentWordFrom()
        {
            InitializeComponent();
        }

        List<char> distinctChars = new List<char>();
        private void frequentWordButton_Click(object sender, EventArgs e)
        {
            string userInput;
            userInput = inputTextBox.Text.Trim();

            GetDistinctChars(userInput);
            char mostFrequent = GetMostFrequentChar(userInput);

            MessageBox.Show("Most frequent character is: " + mostFrequent);

        }

        private char GetMostFrequentChar(string s)
        {
            //array that has the same number of elements as the distict char list
            int[] charIndex = new int[distinctChars.Count];

            //compare each distinct character with all chars in the string
            //if match is found, increase the value if index corresponding with the index of that distinct character
            for (int i = 0; i < distinctChars.Count; i++)
            {
                for (int c = 0; c < s.Length; c++)
                {
                    if (distinctChars[i] == s[c])
                        charIndex[i] += 1;
                }
            }

            //get the index with highest value. This corresponds with number of occurences of a letter of the same index from the distinctChar list
            int index = Array.IndexOf(charIndex, charIndex.Max());
            return distinctChars[index];
        }

        private void GetDistinctChars(string s)
        {
            foreach (char c in s)
            {
                if (!distinctChars.Contains(c) && c != ' ')
                    distinctChars.Add(c);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // This will close the form
            this.Close();
        }
    }
}
