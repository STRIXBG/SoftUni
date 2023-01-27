using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int primaryMatrixSum = 0, secondaryMatrixSum=0;
            for (int i = 0; i < size; i++)
            {
                var line = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                int columnIndex = 0;
                foreach (int num in line)
                {
                    matrix[i, columnIndex] = num;
                    columnIndex++;
                }
            }
            //Primary Matrix
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if(i== j)
                    {
                        primaryMatrixSum += matrix[i, j];
                    }
                }
            }
            //Secondary Matrix
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i + j) == (size - 1))
                    {
                        secondaryMatrixSum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine(Math.Abs(primaryMatrixSum-secondaryMatrixSum));
        }
    }
}
