int capacityOfElevator = int.Parse(Console.ReadLine());
int numberOfPeople = int.Parse(Console.ReadLine());
int courses = (int)Math.Ceiling((double)capacityOfElevator / numberOfPeople);
Console.WriteLine(courses);
