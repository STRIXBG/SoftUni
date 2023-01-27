namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];
            var queue = new Queue<int>();
            int[] numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers2.Count(); i++)
            {
                queue.Enqueue(numbers2[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(x))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
