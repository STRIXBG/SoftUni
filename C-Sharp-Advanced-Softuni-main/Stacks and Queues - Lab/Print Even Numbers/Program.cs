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
            string input = Console.ReadLine();
            Queue<int> quene = new Queue<int>();
            int queneCount = 0;
            foreach (char ch in input)
            {
                if (Char.IsDigit(ch))
                {
                    int number = int.Parse(ch.ToString());
                    if (number % 2 == 0)
                    {
                        quene.Enqueue(number);
                        queneCount++;
                    }
                }
            }
            int index = 1;
            foreach (int num in quene)
            {
                if (index < queneCount)
                {
                    Console.Write(num + ", ");
                }
                else
                {
                    Console.Write(num + " ");
                }
                index++;
            }
        }
    }
}
