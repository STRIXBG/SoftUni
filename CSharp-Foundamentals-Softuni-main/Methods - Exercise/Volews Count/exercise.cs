int ReturnVolewsCount(string word)
{
    int volewsCount=0;
    foreach(char ch in word)
    {
        char upperCh = Char.ToUpper(ch);
        if (upperCh == 'A' || upperCh == 'O' || upperCh == 'U' || upperCh == 'E' || upperCh == 'I')
        {
            volewsCount++;
        }
    }
    return volewsCount;
}

string word = Console.ReadLine();
Console.WriteLine(ReturnVolewsCount(word));
