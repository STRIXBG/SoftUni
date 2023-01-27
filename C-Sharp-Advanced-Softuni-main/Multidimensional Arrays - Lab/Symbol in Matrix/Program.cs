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
            string[] matrix = new string[size];
            for (int i = 0; i < size; i++) //row
            {
                string line = Console.ReadLine();
                matrix[i] = line;
            }
            char chr = Console.ReadLine()[0];
            int indexRow = 0;
            bool foundSymb = false;
            foreach (string line in matrix)
            {
                int occurancy = line.IndexOf(chr);
                if (occurancy != -1)
                {
                    int row = indexRow;
                    int column = occurancy;
                    Console.WriteLine(" ({0}, {1}) ",row,column);
                    foundSymb = true;
                    break;
                }
                indexRow++;
            }
            if (!foundSymb)
            {
                Console.WriteLine("{0} does not occur in the matrix",chr);
            }
        }
    }
}
