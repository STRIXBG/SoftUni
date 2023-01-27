int nChars = int.Parse(Console.ReadLine());
int sum = 0;
for(int i = 0; i < nChars; i++)
{
    char ch = Console.ReadLine()[0];
    sum += (int)ch;
}
Console.WriteLine($"The sum equals: {sum}");
