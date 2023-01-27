int Sum(int first, int second)
{
    return first + second;
}
int Subtract(int third, int result)
{
    return result-third;
}


int first, second, third;
first = int.Parse(Console.ReadLine());
second = int.Parse(Console.ReadLine());
third = int.Parse(Console.ReadLine());

int sum = Sum(first, second);
int subtract = Subtract(third, sum);
Console.WriteLine(subtract);
