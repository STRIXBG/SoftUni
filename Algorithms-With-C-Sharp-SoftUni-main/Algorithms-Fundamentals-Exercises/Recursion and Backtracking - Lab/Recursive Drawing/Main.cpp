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
        static int startN;
        static void PrintFigure(int n, char symbol)
        {

            Console.WriteLine(new String(symbol, n));
        }
        static int Draw(int n)
        {
            if(n == 0)
            {
                Draw2(1);
                return 0;
            }
            PrintFigure(n, '*');
            return Draw(n-1);
        }
        static int Draw2(int n)
        {
            if (n == startN+1)
            {
                return 0;
            }
            PrintFigure(n, '#');
            return Draw2(n + 1);
        }
        static void Main(string[] args)
        {
            startN = int.Parse(Console.ReadLine());
            Draw(startN);
        }
    }
}
