double findFactorial(int n)
{
    int result = n;
    for(int i=n-1; i>=1; i--)
    {
        result = result * i;
    }
    return result;
}

int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
double firstFac = findFactorial(firstNum);
double secondFac = findFactorial(secondNum);

double result = firstFac / secondFac;
Console.WriteLine($"{result:0.00}");
