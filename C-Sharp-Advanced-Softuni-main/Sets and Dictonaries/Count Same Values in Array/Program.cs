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
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            string[] line = Console.ReadLine().Split(' ');
            double[] numbers = Array.ConvertAll(line, double.Parse);
            Dictionary<double, int> dict = new Dictionary<double, int>();
            foreach(double key in numbers)
            {
                bool keyExists = dict.ContainsKey(key);
                if (!keyExists)
                {
                    dict.Add(key, 1);
                }
                else
                {
                    dict[key]++;
                }
            }
            foreach (var num in dict)
            {
                Console.WriteLine("{0} - {1} times",num.Key, num.Value);
            }
        }
    }
}
