int getSumOfDigits(int num)
{
    int sum = 0;
    int tmpNum = num;
    while(tmpNum > 0)
    {
        sum += tmpNum % 10;
        tmpNum /= 10;
    }
    return sum;
}

bool isSpecial(int num)
{
    bool isSpecial = false;
    int sumOfDigits = getSumOfDigits(num);
    if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
    {
        isSpecial = true;
    }
    return isSpecial;
}

//A number is special when its sum of digits is 5, 7, or 11.

int endNum = int.Parse(Console.ReadLine());
for (int i = 1; i <= endNum; i++)
{
    Console.WriteLine($"{i} -> {isSpecial(i)}");
}
