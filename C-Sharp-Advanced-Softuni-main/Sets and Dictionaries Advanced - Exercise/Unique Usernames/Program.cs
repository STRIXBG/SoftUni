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
            var set = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());
            for(int i=0; i<count; i++)
            {
                set.Add(Console.ReadLine());
            }
            foreach(string s in set)
            {
                Console.WriteLine(s);
            }
        }
    }
}
