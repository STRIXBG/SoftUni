// See https://aka.ms/new-console-template for more information

namespace Farm
{
    public class Program
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("eating…");
            }
        }
        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("barking…");
            }
        }
        class Puppy : Dog
        {
            public void Weep()
            {
                Console.WriteLine("weeping…");
            }
        }
        static void Main()
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

        }
    }
}
