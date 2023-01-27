string characters = String.Empty;
for(int i=0; i<3; i++)
{
    char chr = Console.ReadLine()[0];
    characters += chr;
}
string reversed=String.Empty;
for(int i=2; i>=0; i--)
{
    reversed += characters[i];
    reversed += ' ';
}
Console.WriteLine(reversed);
