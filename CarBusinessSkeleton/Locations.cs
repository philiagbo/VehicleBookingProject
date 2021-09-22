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
    public partial class Locations : Form
    {
        public static  int index = 0;
        public string locationOne;
        public string locationTwo;
        public string locationThree;
        public string locationFour;
        
        //reading in all the location files 
        string[] London = File.ReadAllLines("Location1.csv");
        string[] Lisbon = File.ReadAllLines("Location2.csv");
        string[] Tokyo = File.ReadAllLines("Location3.csv");
        string[] Paris = File.ReadAllLines("Location4.csv");

        // each list stores the vehicle object from their specific location 
        List<VehicleData> vehicles = new List<VehicleData>();
        List<VehicleData> vehicles2 = new List<VehicleData>();
        List<VehicleData> vehicles3 = new List<VehicleData>();
        List<VehicleData> vehicles4 = new List<VehicleData>();



        public Locations()
        {
            InitializeComponent();

            //adds the name of the location to the list box
            locationsList.Items.Add("London");
            locationsList.Items.Add("Lisbon");
            locationsList.Items.Add("Tokyo");
            locationsList.Items.Add("Paris");

            ReadData();
        }

        private void selectLocation_Click(object sender, EventArgs e)
        {
            
                Form myForm = new Vehicles(vehicles, vehicles2, vehicles3, vehicles4); // this passes the lists to the next form
                myForm.Show();

            

        }

        private void locationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (locationsList.SelectedIndex == 0)
            {
                index = 0;
                int price = 0;
                int highestExpensive = 0;
                for (int i = 0; i < London.Length; i++)
                {
                    int currentMostExpensive = 0;
                    int IndexStorage = 0;
                    string[] bits = London[i].Split(',');
                    if (bits[i] == "London")
                    {
                        continue;
                    }

                    else
                    {
                        price += int.Parse(bits[4]); // works out
                        totalValue.Text = "£" + price.ToString();
                        currentMostExpensive = int.Parse(bits[4]);
                        if (currentMostExpensive > highestExpensive)
                        {
                            highestExpensive = currentMostExpensive;

                            IndexStorage = i;

                            if (London[i] == London[IndexStorage])
                            {
                                mostExpensiveType.Text = bits[0].ToString(); // displays the vehicle the type of vehicle that is the most expensive
                            }

                        }
                    }

                }

 
                int numOfVehicles = London.Length - 1; // works out the number of vehicles in that stock
                vehiclesInStock.Text = numOfVehicles.ToString(); // displays the number of vehicles in the label in forms
                mostExpensive.Text = highestExpensive.ToString(); // displays the most expensive price in stock
            }


            if (locationsList.SelectedIndex == 1)
            {
                index = 1;
                int price = 0;
                int highestExpensive = 0;
                for (int i = 0; i < Lisbon.Length; i++)
                {
                    int currentMostExpensive = 0;
                    int IndexStorage = 0;
                    string[] bits = Lisbon[i].Split(',');
                    if (bits[i] == "Lisbon")
                    {
                        continue;
                    }

                    else
                    {
                        price += int.Parse(bits[4]);
                        totalValue.Text = "£" + price.ToString();
                        currentMostExpensive = int.Parse(bits[4]);
                        if (currentMostExpensive > highestExpensive)
                        {
                            highestExpensive = currentMostExpensive;

                            IndexStorage = i;

                            if (Lisbon[i] == Lisbon[IndexStorage])
                            {
                                mostExpensiveType.Text = bits[0].ToString();
                            }
                            
                        }
                    }

                }
                int numOfVehicles = Lisbon.Length - 1;
                vehiclesInStock.Text = numOfVehicles.ToString();
                mostExpensive.Text = highestExpensive.ToString();
            }


            if (locationsList.SelectedIndex == 2)
            {
                index = 2;
                int price = 0;
                int highestExpensive = 0;
                for (int i = 0; i < Tokyo.Length; i++)
                {
                    int currentMostExpensive = 0;
                    int IndexStorage = 0;
                    string[] bits = Tokyo[i].Split(',');
                    if (bits[i] == "Tokyo")
                    {
                        continue;
                    }

                    else
                    {
                        price += int.Parse(bits[4]);
                        totalValue.Text = "£" + price.ToString();
                        currentMostExpensive = int.Parse(bits[4]);
                        if (currentMostExpensive > highestExpensive)
                        {
                            highestExpensive = currentMostExpensive;
                            IndexStorage = i;

                            if (Tokyo[i] == Tokyo[IndexStorage])
                            {
                                mostExpensiveType.Text = bits[0].ToString();
                            }
                        }
                    }

                }
                int numOfVehicles = Tokyo.Length - 1;
                vehiclesInStock.Text = numOfVehicles.ToString();
                mostExpensive.Text = highestExpensive.ToString();
            }


            if (locationsList.SelectedIndex == 3)
            {
                index = 3;
                int price = 0;
                int highestExpensive = 0;
                for (int i = 0; i < Paris.Length; i++)
                {
                    int currentMostExpensive = 0;
                    int IndexStorage = 0;
                    string[] bits = Paris[i].Split(',');
                    if (bits[i] == "Paris")
                    {
                        continue;
                    }

                    else
                    {
                        price += int.Parse(bits[4]);
                        totalValue.Text = "£" + price.ToString();
                        currentMostExpensive = int.Parse(bits[4]);
                        if (currentMostExpensive > highestExpensive)
                        {
                            highestExpensive = currentMostExpensive;

                            IndexStorage = i;

                            if (Lisbon[i] == Lisbon[IndexStorage])
                            {
                                mostExpensiveType.Text = bits[0].ToString();
                                IndexStorage = i;

                                if (Paris[i] == Paris[IndexStorage])
                                {
                                    mostExpensiveType.Text = bits[0].ToString();
                                }
                            }
                        }
                    }

                }
                int numOfVehicles = Paris.Length - 1;
                vehiclesInStock.Text = numOfVehicles.ToString();
                mostExpensive.Text = highestExpensive.ToString();

            }            

          
        }

        public void ReadData()
        {
            
            string[] London = File.ReadAllLines("Location1.csv");

            for (int i = 1; i < London.Length; i++)
            {
                string[] bits = London[i].Split(','); // splits the elements in the file according to commas

                if (bits[0] == "Car")
                {
                    // creates a car object from the bits in the location and adds it to the list
                    Car one = new Car(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), double.Parse(bits[9]), bool.Parse(bits[10]));
                    vehicles.Add(one);
                }

                if (bits[0] == "Truck")
                {
                    Truck two = new Truck(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                    vehicles.Add(two);
                }

                if (bits[0] == "Helicopter")
                {
                    Helicopter three = new Helicopter(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                    vehicles.Add(three);
                }

                if (bits[0] == "Plane")
                {
                    Plane four = new Plane(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                    vehicles.Add(four);
                }
            }

            string[] Lisbon = File.ReadAllLines("Location2.csv");

            for (int i = 1; i < Lisbon.Length; i++)
            {
                string[] bits = Lisbon[i].Split(',');

                if (bits[0] == "Car")
                {
                    Car one = new Car(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), double.Parse(bits[9]), bool.Parse(bits[10]));
                    vehicles2.Add(one);
                }

                if (bits[0] == "Truck")
                {
                    Truck two = new Truck(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                    vehicles2.Add(two);
                }

                if (bits[0] == "Helicopter")
                {
                    Helicopter three = new Helicopter(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                    vehicles2.Add(three);
                }

                if (bits[0] == "Plane")
                {
                    Plane four = new Plane(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                    vehicles2.Add(four);
                }
            }


            string[] Tokyo = File.ReadAllLines("Location3.csv");
            for(int i = 1; i < Tokyo.Length; i++)
            {
                string[] bits = Tokyo[i].Split(',');

                if (bits[0] == "Car")
                {
                    Car one = new Car(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), double.Parse(bits[9]), bool.Parse(bits[10]));
                    vehicles3.Add(one);
                }

                if (bits[0] == "Truck")
                {
                    Truck two = new Truck(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                    vehicles3.Add(two);
                }

                if (bits[0] == "Helicopter")
                {
                    Helicopter three = new Helicopter(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                    vehicles3.Add(three);
                }

                if (bits[0] == "Plane")
                {
                    Plane four = new Plane(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                    vehicles3.Add(four);
                }
            }
            string[] Paris = File.ReadAllLines("Location4.csv");
            for(int i = 1; i < Paris.Length; i++)
            {
                string[] bits = Paris[i].Split(',');

                if (bits[0] == "Car")
                {
                    Car one = new Car(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), double.Parse(bits[9]), bool.Parse(bits[10]));
                    vehicles4.Add(one);
                }

                if (bits[0] == "Truck")
                {
                    Truck two = new Truck(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], int.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                    vehicles4.Add(two);
                }

                if (bits[0] == "Helicopter")
                {
                    Helicopter three = new Helicopter(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]));
                    vehicles4.Add(three);
                }

                if (bits[0] == "Plane")
                {
                    Plane four = new Plane(bits[1], bits[2], int.Parse(bits[3]), int.Parse(bits[4]), int.Parse(bits[5]), bits[6], bits[7], bool.Parse(bits[8]), int.Parse(bits[9]), int.Parse(bits[10]), int.Parse(bits[11]), bits[12]);
                    vehicles4.Add(four);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
