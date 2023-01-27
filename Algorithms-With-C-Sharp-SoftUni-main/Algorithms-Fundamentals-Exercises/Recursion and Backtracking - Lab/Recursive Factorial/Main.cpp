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
        static int factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * factorial(n - 1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial(n));
        }
    }
}
