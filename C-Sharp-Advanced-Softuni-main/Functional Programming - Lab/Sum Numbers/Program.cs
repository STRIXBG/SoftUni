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
            int[] numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }
    }
}
