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
        class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine("meowing…");
            }
        }
        static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }

    }
}
