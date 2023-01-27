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
            Stack<string> stack = new Stack<string>();
            foreach(char ch in input)
            {
                stack.Push(ch.ToString());
            }
            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
