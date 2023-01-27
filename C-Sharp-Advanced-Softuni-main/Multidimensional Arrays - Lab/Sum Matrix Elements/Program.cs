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
            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            int sum = 0;

            for(int i=0; i<rows; i++)
            {
                input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
                int[] ints = Array.ConvertAll(input, int.Parse);

                for (int j=0; j<cols; j++)
                {
                    sum += ints[j];
                }
            }

            //Printing the result:
            Console.WriteLine(rows); // Prints count of rows
            Console.WriteLine(cols); // Prints count of cols
            Console.WriteLine(sum); // Prints sum of matrix
        }
    }
}
