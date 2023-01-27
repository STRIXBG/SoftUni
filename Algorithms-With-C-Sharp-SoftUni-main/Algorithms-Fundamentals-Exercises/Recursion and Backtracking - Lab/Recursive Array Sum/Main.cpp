using System;
using System.Threading;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int sum = 0;
        private static int Sum(ref int[] array, int start, int end)
        {
            if(start == end)
            {
                return sum;
            }
            sum += array[start];
            return Sum(ref array, start+1, end);
        }
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Sum(ref array, 0, array.Length);
            Console.WriteLine(sum);
        }
    }
}
