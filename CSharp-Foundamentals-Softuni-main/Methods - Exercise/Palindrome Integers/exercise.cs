bool IsPalindrome(int num)
{
    bool isPalindrome = false;
    int tmpNum = num;
    int reversed = 0;
    while (tmpNum > 0)
    {
        int rem = tmpNum % 10;
        reversed = reversed * 10 + rem;
        tmpNum /= 10;
    }
    if(reversed==num) isPalindrome=true;
    return isPalindrome;
}

string input=String.Empty;
do
{
    input = Console.ReadLine();
    if (input == "END") break;
    int number = int.Parse(input);
    if (IsPalindrome(number)==true)
    {
        Console.WriteLine($"{number} -> true");
    }
    else
    {
        Console.WriteLine($"{number} -> false");
    }

}while (input != "END");
