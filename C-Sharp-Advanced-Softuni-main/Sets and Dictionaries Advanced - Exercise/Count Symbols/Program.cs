using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    internal class SetsAndDicts
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<char, int>();
            foreach(char ch in input)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            foreach (var item in dict.OrderBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
