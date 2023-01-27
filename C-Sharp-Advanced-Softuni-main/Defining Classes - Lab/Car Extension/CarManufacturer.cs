using System;
using System.Threading;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    internal class CarManufacturer
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
