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
        private static int reverse(ref int[] numbers, int start, int end)
        {
            if (start < end)
            {
                int temp = numbers[start];
                numbers[start] = numbers[end];
                numbers[end] = temp;
                return reverse(ref numbers, start + 1, end - 1);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            reverse(ref numbers, 0, numbers.Length-1);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
