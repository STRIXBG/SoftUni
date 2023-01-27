char character = Console.ReadLine()[0];
int asciiChar = (int)character;
bool isUpper = false;
if(asciiChar >= 65 && asciiChar <= 90)
{
    isUpper = true;
}
if (isUpper == true)
{
    Console.WriteLine("upper-case");
}
else
{
    Console.WriteLine("lower-case");
}
