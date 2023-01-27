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
            int count = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();
            for(int i=0; i<count; i++)
            {
                string[] sequence = Console.ReadLine().Split(' ').ToArray();
                foreach(string s in sequence)
                {
                    set.Add(s);
                }
            }
            Console.WriteLine(string.Join(" ", set));
        }
    }
}
