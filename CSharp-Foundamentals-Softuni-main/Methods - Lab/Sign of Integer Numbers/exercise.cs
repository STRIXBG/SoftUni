void defNumber(int num)
{
    if (num >= 1)
    {
        Console.WriteLine($"The number {num} is positive.");
    }
    else if(num == 0)
    {
        Console.WriteLine($"The number {num} is zero.");
    }
    else
    {
        Console.WriteLine($"The number {num} is negative.");
    }
}
int number = int.Parse(Console.ReadLine());
defNumber(number);
