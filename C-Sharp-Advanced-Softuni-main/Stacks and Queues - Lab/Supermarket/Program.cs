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
            Queue<string> quene = new Queue<string>();
            String input = Console.ReadLine();
            while (input.ToUpper() != "END")
            {
                if (input.ToUpper() == "PAID")
                {
                    foreach (string person in quene)
                    {
                        Console.WriteLine(person);
                    }
                    quene.Clear();
                }
                else
                {
                    quene.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(quene.Count() + " people remaining.");
        }
    }
}
