using System;
using System.Threading;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoftUni
{
    internal class Program
    {
        static double ReturnValue(double num)
        {
            double VAT = num * 0.2;
            return num+VAT;
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            double[] numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(double.Parse).ToArray();
            foreach(double number in numbers)
            {
                Console.WriteLine($"{ReturnValue(number):f2}");
            }
        }
    }
}
