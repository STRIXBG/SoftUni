//If the second letter's ASCII value is less than
//that of the first one then the two initial letters should be swapped.

void printCharsInRange(char start, char end)
{
    string result=String.Empty;
    int asciiStart, asciiEnd;
    asciiStart = (int)start;
    asciiEnd = (int)end;
    for(int i = start+1; i < end; i++)
    {
        result = result + (char)i + ' ';
    }
    Console.WriteLine(result);
}
char start, end;
start = Console.ReadLine()[0];
end = Console.ReadLine()[0];
printCharsInRange(start, end);
