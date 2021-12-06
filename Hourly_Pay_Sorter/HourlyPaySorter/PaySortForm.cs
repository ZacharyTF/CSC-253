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
* 09-30-2021
* CSC 253
* Zachary Fegan
* This program will demonstrate how to display a table from a database and sort those records with buttons.
*/


namespace HourlyPaySorter
{
    public partial class PaySortForm : Form
    {
        public PaySortForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void PaySortForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        private void accendingSortButton_Click(object sender, EventArgs e)
        {
            // This sorts the HourlyPayRate column in accending order
            this.employeeTableAdapter.FillByHourlyPayRate(this.personnelDataSet.Employee);
        }

        private void decendingSortButton_Click(object sender, EventArgs e)
        {
            // This sorts the HourlyPayRate column in descending order
            this.employeeTableAdapter.FillByHourlyPayRateDesc(this.personnelDataSet.Employee);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // This closes the form
            this.Close();
        }
    }
}
