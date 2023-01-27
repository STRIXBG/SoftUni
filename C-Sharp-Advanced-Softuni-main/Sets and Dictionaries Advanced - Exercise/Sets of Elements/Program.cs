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
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len1 = sequence[0];
            int len2 = sequence[1];
            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();
            var commonSet = new HashSet<int>();
            for (int i=0; i<len1; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for(int i=0; i<len2; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }
            foreach(var element in set2)
            {
                if (set1.Contains(element))
                {
                    commonSet.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", commonSet));
        }
    }
}
