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
* 10/06/2021
* CSC 253
* Zachary Fegan
* This program demonstrates how edit, search, and sort items in a table from a database
*/

namespace PopulationDB
{
    public partial class PopulationForm : Form
    {
        public PopulationForm()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDataSet);

        }

        private void PopulationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDataSet.City);
        }

        private void sortAscendButton_Click(object sender, EventArgs e)
        {
            // Sorts all the city's population in ascending order
            this.cityTableAdapter.FillByPopulation(this.populationDataSet.City);
        }

        private void sortDescendButton_Click(object sender, EventArgs e)
        {
            // Sorts all the city's population in desending order
            this.cityTableAdapter.FillByPopulationDesc(this.populationDataSet.City);
        }

        private void sortNameButton_Click(object sender, EventArgs e)
        {
            // Sorts all the cities in the table by the city's name
            this.cityTableAdapter.FillByCityName(this.populationDataSet.City);
        }

        private void getHighPopButton_Click(object sender, EventArgs e)
        {
            // Displays all the cities with a high population amount
            this.cityTableAdapter.FillByHighPopulation(this.populationDataSet.City);
        }

        private void getAveragePopButton_Click(object sender, EventArgs e)
        {
            // Displays all the cities with an average population amount to the user
            this.cityTableAdapter.FillByAveragePopulation(this.populationDataSet.City);
        }

        private void getLowPopButton_Click(object sender, EventArgs e)
        {
            // Displays all the cities with a low population to the user
            this.cityTableAdapter.FillByLowestPopulation(this.populationDataSet.City);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            // Displays all the data in the table to the user
            this.cityTableAdapter.Fill(this.populationDataSet.City);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }
    }
}
