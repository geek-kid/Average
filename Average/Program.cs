using System.ComponentModel;

string[] courses = { "math", "programming", "ebglish lang", "persian lang", "advanced programming", "network", "data structure", "data base", "advanced programming 2", "mobile programming"};
int sumPoints = 0, point = 0, sumRatio = 0;

foreach (var course in courses)
{
    Console.WriteLine($"course's point: {course}");
    try
    {
        point = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ratio?");
        sumRatio = sumRatio + Convert.ToInt32(Console.ReadLine());
        sumPoints = sumPoints + (point * sumRatio);
    }
    catch {
        Console.WriteLine("Bad input...\nhere you go again :)");
    }
}

Console.WriteLine($"Avarage: {sumPoints / (courses.Length + sumRatio)}");
