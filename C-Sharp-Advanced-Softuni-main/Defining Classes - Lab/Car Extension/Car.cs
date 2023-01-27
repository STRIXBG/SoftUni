using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        private int fuelQuantity;
        private int	fuelConsumption;
        public string Make   // property
        {
            get { return make; }   // get method
            set { make = value; }  // set method
        }
        public string Model   // property
        {
            get { return model; }   // get method
            set { model = value; }  // set method
        }
        public int Year   // property
        {
            get { return year; }   // get method
            set { year = value; }  // set method
        }
        public int FuelQuantity   // property
        {
            get { return fuelQuantity; }   // get method
            set { fuelQuantity = value; }  // set method
        }
        public int FuelConsumption   // property
        {
            get { return fuelConsumption; }   // get method
            set { fuelConsumption = value; }  // set method
        }
        public void Drive(double distance)
        {
            if((FuelQuantity - distance)*FuelConsumption < 1)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return string.Format($"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity}");
        }
    }
}
