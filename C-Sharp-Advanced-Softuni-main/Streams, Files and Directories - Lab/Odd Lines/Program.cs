namespace OddLines
{
    using System;
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            string allText = string.Empty;
            int index = 0;
            foreach (string line in lines)
            {
                if (index % 2 != 0)
                {
                    Console.WriteLine(line);
                    allText += string.Format($"{line}\n");
                }
                index++;
            }
            File.WriteAllText(outputFilePath, allText);
        }
    }
}
