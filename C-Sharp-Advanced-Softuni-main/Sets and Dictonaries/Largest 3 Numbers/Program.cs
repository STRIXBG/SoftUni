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
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sorted = numbers.OrderByDescending(x => x).ToArray();
            for(int i=0; i<3; i++)
            {
                Console.Write(sorted[i] + " ");
            }
        }
    }
}
