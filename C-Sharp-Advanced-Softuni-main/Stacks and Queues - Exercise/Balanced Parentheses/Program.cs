using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    internal class SongsQuene
    {
        static void Main(string[] args)
        {
            var stack = new Stack<char>();
            string line = Console.ReadLine();
            bool success = true;
            foreach (char ch in line)
            {
                switch (ch)
                {
                    case '(':
                        {
                            stack.Push('(');
                            break;
                        }
                    case ')':
                        {
                            char pop = stack.Pop();
                            if (pop != '(')
                                success = false;
                            break;
                        }
                    case '[':
                        {
                            stack.Push('[');
                            break;
                        }
                    case ']':
                        {
                            char pop = stack.Pop();
                            if (pop != '[')
                                success = false;
                            break;
                        }
                    case '{':
                        {
                            stack.Push('{');
                            break;
                        }
                    case '}':
                        {
                            char pop = stack.Pop();
                            if (pop != '{')
                                success = false;
                            break;
                        }
                }
            }
            if (success)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
