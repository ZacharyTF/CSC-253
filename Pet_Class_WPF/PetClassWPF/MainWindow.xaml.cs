using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/**
* 11/29/2021
* CSC 253
* Zachary Fegan
* This is the WPF for the pet class application
*/

namespace PetClassWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddPet_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtPetName.Text + txtPetType.Text + txtPetAge.Text) && !lstOfPets.Items.Contains(txtPetName.Text + txtPetType.Text + txtPetAge.Text))
            {
                lstOfPets.Items.Add(txtPetName.Text + " " + txtPetType.Text + " " + txtPetAge.Text);
                txtPetName.Clear();
                txtPetType.Clear();
                txtPetAge.Clear();
                txtPetName.Focus();
            }
            else
            {
                MessageBox.Show("Empty pet information or the pet has been already added to list!");
            }
        }
    }
}
