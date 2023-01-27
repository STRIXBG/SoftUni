using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    internal class Functions
    {
        static void Main()
        {
            int len = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(' ').ToList();
            var resultNames = new List<string>();
            foreach(var name in names)
            {
                Predicate<string> isLenghtEnough = x => x.Length <= len;
                if (isLenghtEnough(name))
                {
                    resultNames.Add(name);
                }
            }
            foreach(var name in resultNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
