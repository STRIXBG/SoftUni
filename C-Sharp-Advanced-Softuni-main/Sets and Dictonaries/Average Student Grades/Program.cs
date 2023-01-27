using System;
using System.Threading;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            int students = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();
            for (int i = 0; i < students; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                string keyName = line[0];
                double valueGrade = double.Parse(line[1]);
                bool keyExists = dict.ContainsKey(keyName);
                if (!keyExists)
                {
                    dict.Add(keyName, new List<double>());
                }
                dict[keyName].Add(valueGrade);
            }
            foreach (var student in dict)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {student.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
