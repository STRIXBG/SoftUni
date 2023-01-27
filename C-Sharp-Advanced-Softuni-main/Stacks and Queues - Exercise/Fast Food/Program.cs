using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    internal class MaxAndMin
    {
        static void Main(string[] args)
        {
            var quene = new Queue<int>();
            int foodQuanity = int.Parse(Console.ReadLine());
            int foodOrders = 0;
            int foodLeft = 0;
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < sequence.Count(); i++)
            {
                quene.Enqueue(sequence[i]);
                foodOrders += sequence[i];
                if (foodOrders > foodQuanity)
                {
                    foodLeft += sequence[i];
                }
            }
            Console.WriteLine(quene.Max());
            if (foodLeft > 0)
                Console.WriteLine($"Orders Left: {foodLeft}");
            else
                Console.WriteLine("Orders complete");
        }
    }
}
