int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
int hoursAfter30Min = hours;
int minutsAfter30Min = minutes+30;
if (minutes+30 >= 60)
{
    minutsAfter30Min -= 60;
    hoursAfter30Min += 1;
}
Console.WriteLine("{0}:{1}",hoursAfter30Min,minutsAfter30Min);
