using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    internal class MaxAndMin
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            int linesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < linesCount; i++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int command = line[0];
                switch (command)
                {
                    case 1:
                        {
                            int num = line[1];
                            stack.Push(num);
                            break;
                        }
                    case 2:
                        {
                            stack.Pop();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(stack.Max());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(stack.Min());
                            break;
                        }
                }
            }
            if (stack.Count > 0)
                Console.WriteLine(String.Join(", ", stack));
        }
    }
}
