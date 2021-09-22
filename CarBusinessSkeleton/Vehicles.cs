using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarBusinessSkeleton
{
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();

        }

       
        public Vehicles(List<VehicleData> vehicles, List<VehicleData> vehicles2, List<VehicleData> vehicles3, List<VehicleData> vehicles4)

        {
            InitializeComponent();
            if (Locations.index ==0)
            {
                for (int i = 0; i < vehicles.Count; i++)
                {
                    vehiclesListBox.Items.Add(vehicles[i]);
                }
            }
            if (Locations.index == 1)
            {
                for (int i = 0; i < vehicles2.Count; i++)
                {
                    vehiclesListBox.Items.Add(vehicles2[i]);
                }
            }
            if (Locations.index == 2)
            {
                for (int i = 0; i < vehicles3.Count; i++)
                {
                    vehiclesListBox.Items.Add(vehicles3[i]);
                }
            }
            if (Locations.index == 3)
            {
                for (int i = 0; i < vehicles4.Count; i++)
                {
                    vehiclesListBox.Items.Add(vehicles4[i]);
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form myform = new Vehicle();
            myform.Show();

            


        }

        private void modify_Click(object sender, EventArgs e)
        {
            Form myform = new Vehicle();
            myform.Show();
        }

        private void vehiclesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {
            vehiclesListBox.Items.Remove(vehiclesListBox.Items[vehiclesListBox.SelectedIndex]); //deletes the selected item in the listbox
        }
    }
}
