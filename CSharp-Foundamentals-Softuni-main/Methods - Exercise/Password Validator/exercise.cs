bool PasswordRuleOnlyDigsAndLetts(string password)
{
    bool validate = true;
    foreach(char ch in password)
    {
        if (!(ch >= '0' && ch <= '9') && !(ch >= 'a' && ch <= 'z') && !(ch >= 'A' && ch <= 'Z'))
        {
            validate = false;
        }
    }
    return validate;
}

bool PasswordRuleChars(string password)
{
    bool validate=false;
    if(password.Length >= 6 && password.Length <= 10) validate=true;
    return validate;
}

bool PasswordRuleDigits(string password)
{
    int digitsCount = 0;
    bool validate = false;
    foreach (char ch in password)
    {
        if (ch >= '0' && ch <= '9')
        {
            digitsCount++;
        }
    }
    if(digitsCount >= 2) validate=true;
    return validate;
}

void PasswordValidate(string password)
{
    bool validPass = true;
    if (PasswordRuleDigits(password)==false)
    {
        Console.WriteLine("Password must have at least 2 digits");
        validPass = false;
    }
    if (PasswordRuleChars(password) == false)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
        validPass = false;
    }
    if (PasswordRuleOnlyDigsAndLetts(password) == false)
    {
        Console.WriteLine("Password must consist only of letters and digits");
        validPass = false;
    }
    if (validPass == true)
    {
        Console.WriteLine("Password is valid");
    }

}
string pass = Console.ReadLine();
PasswordValidate(pass);
