int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
string result = String.Empty;
for(int i = start; i <= end; i++)
{
    result = result + (char)i + ' ';
}
Console.WriteLine(result);
