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
    public partial class Customers : Form
    {
        public string customerOne = "Alex";
        public string customerTwo = "Jack";
        public string customerThree = "Ben";
        public string customerFour = "Eva";

        string[] costumerInventory = File.ReadAllLines("Customer.csv");


        List<VehicleData> alexVehicles = new List<VehicleData>();
        List<VehicleData> jackVehicles = new List<VehicleData>();
        List<VehicleData> benVehicles = new List<VehicleData>();
        List<VehicleData> evaVehicles = new List<VehicleData>();
        public Customers()
        {
            InitializeComponent();

            //adds the names of th costumers to the customer list box
            customerListBox1.Items.Add(customerOne);
            customerListBox1.Items.Add(customerTwo);
            customerListBox1.Items.Add(customerThree);
            customerListBox1.Items.Add(customerFour);

            readCustomerVehicle();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form myform = new Vehicle();
            myform.Show();
        }

        private void customerListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerListBox1.SelectedIndex == 0)
            {
                vehiclesListBox.Items.Clear();
                for (int i = 0; i < alexVehicles.Count; i++)
                {
                    vehiclesListBox.Items.Add(alexVehicles[i]); //adds all vehicles under alex's name in the vehicle list box
                }
            }

            else if (customerListBox1.SelectedIndex == 1)
            {
                vehiclesListBox.Items.Clear();
                for (int i = 0; i < jackVehicles.Count; i++)
                {
                    vehiclesListBox.Items.Add(jackVehicles[i]); //adds all vehicles under jacks name in the vehicle list box
                }
            }

            else if (customerListBox1.SelectedIndex == 2)
            {
                vehiclesListBox.Items.Clear();
                for (int i = 0; i < benVehicles.Count; i++)
                {
                    vehiclesListBox.Items.Add(benVehicles[i]); //adds all vehicles under ben's name in the vehicle list box
                }
            }

            else if (customerListBox1.SelectedIndex == 3)
            {
                vehiclesListBox.Items.Clear();
                for (int i = 0; i < evaVehicles.Count; i++)
                {
                    vehiclesListBox.Items.Add(evaVehicles[i]); //adds all vehicles under Eva's name in the vehicle list box
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vehiclesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            readCustomerVehicle();
        }

        public void readCustomerVehicle()
        {
            bool correctNameOne = false;
            bool correctNameTwo = false;
            bool correctNameThree = false;
            bool correctNameFour = false;

            string[] costumerInventory = File.ReadAllLines("Customer.csv");
            for (int i = 0; i < costumerInventory.Length; i++)
            {
                if (customerOne == costumerInventory[i])
                {
                    correctNameOne = true;
                    correctNameTwo = false;
                    correctNameThree = false;
                    correctNameFour = false;
                    continue;
                }

                 if (customerTwo == costumerInventory[i])
                {
                    correctNameOne = false;
                    correctNameTwo = true;
                    correctNameThree = false;
                    correctNameFour = false;
                    continue;
                }

                if (customerThree == costumerInventory[i])
                {
                    correctNameOne = false;
                    correctNameTwo = false;
                    correctNameThree = true;
                    correctNameFour = false;
                    continue;
                }


                if(customerFour == costumerInventory[i])
                {
                    correctNameOne = false;
                    correctNameTwo = false;
                    correctNameThree = false;
                    correctNameFour = true;
                    continue;
                }

                // when  Alex's name is selected, the file is split into an array of bits and the objects are added to a list for all the vehicles under alex's name
                if (correctNameOne == true)
                {
                    string[] bits = costumerInventory[i].Split(',');

                    if (bits[0] == "Car")
                    {
                        Car one = new Car(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), double.Parse(bits[9]), bool.Parse(bits[10]));
                        alexVehicles.Add(one);
                    }

                    if (bits[0] == "Truck")
                    {
                        Truck two = new Truck(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                        alexVehicles.Add(two);
                    }

                    if (bits[0] == "Helicopter")
                    {
                        Helicopter three = new Helicopter(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                        alexVehicles.Add(three);
                    }

                    if (bits[0] == "Plane")
                    {
                        Plane four = new Plane(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                        alexVehicles.Add(four);
                    }
                }

                // when  Jacks name is selected, the file is split into an array of bits and the objects are added to a list for all the vehicles under jacks name
                if (correctNameTwo == true)
                {
                    string[] bits = costumerInventory[i].Split(',');

                    if (bits[0] == "Car")
                    {
                        Car one = new Car(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), double.Parse(bits[9]), bool.Parse(bits[10]));
                        jackVehicles.Add(one);
                    }

                    if (bits[0] == "Truck")
                    {
                        Truck two = new Truck(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                        jackVehicles.Add(two);
                    }

                    if (bits[0] == "Helicopter")
                    {
                        Helicopter three = new Helicopter(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                        jackVehicles.Add(three);
                    }

                    if (bits[0] == "Plane")
                    {
                        Plane four = new Plane(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                        jackVehicles.Add(four);
                    }
                }

                // when  Ben's name is selected, the file is split into an array of bits and the objects are added to a list for all the vehicles under Ben's name
                if (correctNameThree == true)
                {
                    string[] bits = costumerInventory[i].Split(',');

                    if (bits[0] == "Car")
                    {
                        Car one = new Car(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), double.Parse(bits[9]), bool.Parse(bits[10]));
                        benVehicles.Add(one);
                    }

                    if (bits[0] == "Truck")
                    {
                        Truck two = new Truck(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                        benVehicles.Add(two);
                    }

                    if (bits[0] == "Helicopter")
                    {
                        Helicopter three = new Helicopter(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                        benVehicles.Add(three);
                    }

                    if (bits[0] == "Plane")
                    {
                        Plane four = new Plane(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                        benVehicles.Add(four);
                    }
                }

                // when  Eva's name is selected, the file is split into an array of bits and the objects are added to a list for all the vehicles under Eva's name
                if (correctNameFour == true)
                {
                    string[] bits = costumerInventory[i].Split(',');

                    if (bits[0] == "Car")
                    {
                        Car one = new Car(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), double.Parse(bits[9]), bool.Parse(bits[10]));
                        evaVehicles.Add(one);
                    }

                    if (bits[0] == "Truck")
                    {
                        Truck two = new Truck(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                        evaVehicles.Add(two);
                    }

                    if (bits[0] == "Helicopter")
                    {
                        Helicopter three = new Helicopter(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                        evaVehicles.Add(three);
                    }

                    if (bits[0] == "Plane")
                    {
                        Plane four = new Plane(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                        evaVehicles.Add(four);
                    }
                }
            }
            
            

            
        }

        private void searchVehicleButton_Click(object sender, EventArgs e)
        {
             
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            vehiclesListBox.Items.Remove(vehiclesListBox.Items[vehiclesListBox.SelectedIndex]); //deletes the selected item in the listbox
        }
    }
}
