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
            var dictNumbers = new Dictionary<int, int>();
            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (dictNumbers.ContainsKey(num))
                {
                    dictNumbers[num] += 1;
                }
                else
                {
                    dictNumbers.Add(num, 1);
                }
            }
            foreach(int numKey in dictNumbers.Keys)
            {
                if (dictNumbers[numKey] % 2 == 0)
                {
                    Console.WriteLine(numKey);
                }
            }
        }
    }
}
