//even number - two results
string ReturnMiddleChar(string word)
{
    bool isEven=false;
    if (word.Length % 2 == 0)
    {
        isEven = true;
    }
    string middle=String.Empty;
    if (isEven==true)
    {
        int wordLenDivided = word.Length / 2;
        char MiddleChar1 = word[wordLenDivided-1];
        char MiddleChar2 = word[wordLenDivided];
        middle = middle + MiddleChar1 + MiddleChar2;
    }
    else if (isEven == false)
    {
        int wordLenDivided = word.Length / 2;
        char MiddleChar = word[wordLenDivided];
        middle = middle + MiddleChar;
    }
    return middle;
}

string word = Console.ReadLine();
Console.WriteLine(ReturnMiddleChar(word));
