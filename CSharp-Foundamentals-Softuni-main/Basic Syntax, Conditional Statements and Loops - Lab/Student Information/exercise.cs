// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter student's Name: ");
string studentName = Console.ReadLine();
Console.WriteLine("Enter student's Age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Enter student's Grade: ");
double studentGrade = double.Parse(Console.ReadLine());
Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:F2}", studentName,age,studentGrade);
