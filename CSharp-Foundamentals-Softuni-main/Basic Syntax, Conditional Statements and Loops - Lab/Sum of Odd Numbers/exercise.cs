int number = int.Parse(Console.ReadLine());
int sum=0;
int oddNum = 1;
for(int i=1; i<= number; i++)
{
    sum += oddNum;
    Console.WriteLine(oddNum);
    oddNum = oddNum + 2;
}
Console.WriteLine($"Sum: {sum}");
