using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    internal class Functions
    {

        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(FindSmallest(numbers));
        }
        public static int FindSmallest(int[] sequence)
        {
            int smallest = sequence[0];
            foreach(int number in sequence)
            {
                if(number < smallest)
                {
                    smallest = number;
                }
            }
            return smallest;
        }
    }
}
