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
            string input = Console.ReadLine();
            string[] names = input.Split();
            Action<string[]> printNames = (x) => Print(x);
            printNames(names);
        }
        public static void Print(string[] names)
        {
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
