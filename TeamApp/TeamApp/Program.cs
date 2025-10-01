using System.Text.RegularExpressions;

Console.Write("Enter your name: ");
string fullName = Console.ReadLine();

string pattern = @"^[АЯІЇЄ][аяіїє]+\s[АЯІЇЄ][аяіїє]+$";
bool isTrue = Regex.IsMatch(fullName, pattern);

if (isTrue = true)
{
    Console.WriteLine($"Привiт {fullName}!");
}
else if (isTrue = false)
{
    Console.WriteLine("Помилка при введенні даних");
}
else
{
    Console.WriteLine("Error");
}