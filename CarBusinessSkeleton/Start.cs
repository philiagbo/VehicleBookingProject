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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Business_Click(object sender, EventArgs e)
        {
            Form myForm = new Locations();
            myForm.Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            Form myForm = new Customers();
            myForm.Show();

            string[] costumerInventory = File.ReadAllLines("Customer.csv"); //reads in the customer file into an array of type string
        }

    }
}
