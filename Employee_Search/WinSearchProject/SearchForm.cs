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
* This program will display how to find an element in a table while using a database.
*/


namespace WinSearchProject
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This displays what information the user is looking for.
            this.employeeTableAdapter.SearchName(this.personnelDataSet.Employee, searchEmployeeNameTextBox.Text);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            // This will display all the items in the table 
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // This closes the form
            this.Close();
        }
    }
}
