string numbers = Console.ReadLine();
if (numbers != null)
{
    double[] numbersArr = numbers.Split().Select(double.Parse).ToArray();
    for (int i = 0; i < numbersArr.Length; i++)
    {
        Console.WriteLine(Math.Round(numbersArr[i]));
    }
}
