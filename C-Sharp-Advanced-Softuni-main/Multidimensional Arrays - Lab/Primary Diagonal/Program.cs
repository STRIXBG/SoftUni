using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] matrix;
            int sum = 0;
            for(int i = 0; i < size; i++)
            {
                string line = Console.ReadLine();
                string[] splitedLine = line.Split(' ');
                for (int j=0; j<size; j++)
                {
                    if (i == j)
                    {
                        int number = int.Parse(splitedLine[j]);
                        sum += number;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
