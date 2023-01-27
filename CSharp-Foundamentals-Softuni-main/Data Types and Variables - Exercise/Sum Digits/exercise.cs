int number = int.Parse(Console.ReadLine());
int sum=0;

//Operations:
int tmpNum = number;
while (tmpNum > 0)
{
    int toAdd = tmpNum % 10;
    sum += toAdd;
    tmpNum /= 10;
}
//Result:
Console.WriteLine(sum);
