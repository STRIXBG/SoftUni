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
            Stack<int> stack = new Stack<int>();
            int index = 0;
            foreach(char ch in input)
            {
                if (ch.Equals('('))
                {
                    stack.Push(index);
                }
                else if (ch.Equals(')'))
                {
                    int start = stack.Pop();
                    int final = index;
                    for(int i=start; i<=final; i++)
                    {
                        Console.Write(input[i]);
                    }
                    Console.WriteLine();
                }
                index++;
            }
        }
    }
}
