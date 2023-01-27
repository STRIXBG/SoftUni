void printMatrix(int n)
{
    string[] matrixN = new string[n];
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrixN[i] = matrixN[i] + n + " ";
        }
        Console.WriteLine(matrixN[i]);
    }
}
int number = int.Parse(Console.ReadLine());
printMatrix(number);
