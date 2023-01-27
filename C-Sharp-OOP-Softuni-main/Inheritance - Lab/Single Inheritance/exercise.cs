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
        static void Main()
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Bark();
        }
    }
}
