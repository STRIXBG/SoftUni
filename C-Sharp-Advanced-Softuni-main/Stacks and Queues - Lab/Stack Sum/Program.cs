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
            foreach (char ch in input)
            {
                if (Char.IsDigit(ch))
                {
                    stack.Push(int.Parse(ch.ToString()));
                }
            }
            string line = Console.ReadLine();
            while (line.ToLower() != "end")
            {
                string[] splitedLine = line.Split(' ');
                if (splitedLine[0].ToLower() == "add")
                {
                    int num1 = int.Parse(splitedLine[1]);
                    int num2 = int.Parse(splitedLine[2]);
                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if (splitedLine[0].ToLower() == "remove")
                {
                    int count = int.Parse(splitedLine[1]);
                    if (count < stack.Count())
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                line = Console.ReadLine();
            }
            int sum = 0;
            while(stack.Count() > 0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine(sum); 
        }
    }
}
