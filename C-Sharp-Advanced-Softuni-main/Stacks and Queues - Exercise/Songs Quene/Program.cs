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
            var quene = new Queue<string>();
            var sequence = Console.ReadLine().Split(", ").ToList();
            foreach (var element in sequence)
            {
                quene.Enqueue(element);
            }
            while(quene.Count > 0)
            {
                string input = Console.ReadLine();
                if (input.StartsWith("Play"))
                {
                    quene.Dequeue();
                }
                else if (input.StartsWith("Add"))
                {
                    var songName = input.Substring(4);
                    if (!quene.Contains(songName))
                    {
                        quene.Enqueue(songName);
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                }
                else if(input.StartsWith("Show"))
                {
                    Console.WriteLine(string.Join(", ", quene));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
