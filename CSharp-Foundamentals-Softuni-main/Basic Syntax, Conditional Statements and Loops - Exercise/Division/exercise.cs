int number = int.Parse(Console.ReadLine());
//2, 3, 6, 7, 10
//2, 3, 6 - Divisible by 6
//2, 10 - Divisible by 10

int divisibleBy = -1;

//Calculation:
if(number % 2 == 0)
{
    divisibleBy = 2;
}
if (number % 3 == 0)
{
    divisibleBy = 3;
}
if (number % 6 == 0)
{
    divisibleBy = 6;
}
if (number % 7 == 0)
{
    divisibleBy = 7;
}
if (number % 10 == 0)
{
    divisibleBy = 10;
}
if (number % 2 == 0 && number % 3 == 0 && number % 6 == 0)
{
    divisibleBy = 6;
}
if(number % 2 == 0 && number % 10 == 0)
{
    divisibleBy = 10;
}
//Result:
if (divisibleBy == -1)
{
    Console.WriteLine("Not divisible");
}
else
{
    Console.WriteLine($"The number is divisible by {divisibleBy}");
}
