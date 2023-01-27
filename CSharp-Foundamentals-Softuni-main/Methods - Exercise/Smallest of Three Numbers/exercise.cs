int ReturnSmallestNum(int num1, int num2, int num3)
{
    int smallestNum = num1;
    if(smallestNum > num2) smallestNum = num2;
    if (smallestNum > num3) smallestNum = num3;
    return smallestNum;
}

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine(ReturnSmallestNum(num1,num2,num3));
