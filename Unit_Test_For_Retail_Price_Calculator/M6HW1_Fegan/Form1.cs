using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailCalculatorLibrary;

/*
 * 11-15-2021
 * CSC 253
 * Zachary Fegan
 * Retail Price Calculator Create an application that lets the user enter an item’s wholesale cost and its markup percentage. It should then display the item’s retail price.
 */

namespace M6HW1_Fegan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double wholeSale;
            double markup;

            if(double.TryParse(salePriceTextBox.Text, out wholeSale) && double.TryParse(percentageTextBox.Text, out markup))
            {
                retailPriceLabel.Text = Calculate.CalculateRetail(wholeSale, markup).ToString("C");
            }
            else
            {
                MessageBox.Show("Please enter valid amount of numbers");
            }
        }

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}