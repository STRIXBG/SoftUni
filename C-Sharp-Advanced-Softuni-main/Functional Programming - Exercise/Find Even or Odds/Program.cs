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
            int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = line[0];
            int end = line[1];
            string type = Console.ReadLine();
            var numbers = new List<int>();
            var resultNums = new List<int>();
            for (int i=start; i<=end; i++)
            {
                numbers.Add(i);
            }
            foreach (int number in numbers)
            {
                if (type == "even")
                {
                    Predicate<int> isEven = s => s % 2 == 0;
                    if (isEven(number))
                    {
                        resultNums.Add(number);
                    }
                }
                else
                {
                    Predicate<int> isOdd = s => s % 2 != 0;
                    if (isOdd(number))
                    {
                        resultNums.Add(number);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", resultNums));
        }
    }
}
