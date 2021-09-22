using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusinessSkeleton
{
    //parent class for all vehicles
    public partial class VehicleData
    {
        public string make;
        public string model;
        public int year;
        public int price;
        public int weight;
        public string colour;
        public string registration;

        public VehicleData(string make, string model, int year, int price, int weight, string colour, string registration)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.weight = weight;
            this.colour = colour;
            this.registration = registration;
        }

        // This method allows us to display the objects variables as a string in the vehicle list box
        public override string ToString()
        {
            return GetType().ToString().Split(',')[0] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration;
        }
    }

    //Car class which inherit from my Vehicle data class
    class Car : VehicleData
    {
        public int numberOfDoors;
        public double engineSize;
        public bool electricWindows;

        public Car(string make, string model, int year, int price, int weight, string colour, string registration, int numberOfDoors, double engineSize, bool electricWindows) : base(make, model, year, price, weight, colour, registration)
        {
            this.numberOfDoors = numberOfDoors;
            this.engineSize = engineSize;
            this.electricWindows = electricWindows;
        }

        public override string ToString()
        {
            return GetType().ToString().Split(',')[0] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration + "," + numberOfDoors + "," + engineSize + "," + electricWindows;
        }
    }

    //Truck class which inherit from my Vehicle data class
    class Truck : VehicleData
    {
        public int weightLimit;
        public int numberOfWheels;
        public int length;

        public Truck(string make, string model, int year, int price, int weight, string colour, string registration, int weightLimit, int numberOfWheels, int length) : base(make, model, year, price, weight, colour, registration)
        {
            this.weightLimit = weightLimit;
            this.numberOfWheels = numberOfWheels;
            this.length = length;
        }
        public override string ToString()
        {
            return GetType().ToString().Split(',')[0] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration + "," + weightLimit + "," + numberOfWheels + "," + length;
        }
    }

    //Helicopter class which inherit from my Vehicle data class
    class Helicopter : VehicleData
    {
        public bool airworthy;
        public int hoursUsed;
        public int altitudeLimit;

        public Helicopter(string make, string model, int year, int price, int weight, string colour, string registration, bool airworthy, int hoursUsed, int altitudeLimit) : base(make, model, year, price, weight, colour, registration)
        {
            this.airworthy = airworthy;
            this.hoursUsed = hoursUsed;
            this.altitudeLimit = altitudeLimit;
        }
        public override string ToString()
        {
            return GetType().ToString().Split(',')[0] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration + "," + airworthy + "," + hoursUsed + "," + altitudeLimit;
        }
    }

    //Plane class which inherit from my Vehicle data class
    class Plane : VehicleData
    {
        public bool airworthy;
        public int hoursUsed;
        public int altitudeLimit;
        public int seats;
        public string engine;
        public Plane(string make, string model, int year, int price, int weight, string colour, string registration, bool airworthy, int hoursUsed, int altitudeLimit, int seats, string engine) : base(make, model, year, price, weight, colour, registration)
        {
            this.airworthy = airworthy;
            this.hoursUsed = hoursUsed;
            this.altitudeLimit = altitudeLimit;
            this.seats = seats;
            this.engine = engine;
        }
        public override string ToString()
        {
            return GetType().ToString().Split(',')[0] + "," + make + "," + model + "," + year + "," + price + "," + weight + "," + colour + "," + registration + "," + airworthy + "," + hoursUsed + "," + altitudeLimit + "," + seats + "," + engine;
        }
    }
}
