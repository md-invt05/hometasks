using System.Text.RegularExpressions;
Console.WriteLine("Введите весь путь к файлу");
string path = Console.ReadLine();
try
{
    using (StreamReader reader = new StreamReader(path))
    {
        string text = await reader.ReadToEndAsync();
        Console.WriteLine("Введите слово, которое хотите найти");
        string word = Console.ReadLine();
        
        Regex rx = new Regex(word,RegexOptions.Compiled | RegexOptions.IgnoreCase);

        MatchCollection matches = rx.Matches(text);
        int number = matches.Count;
        Console.WriteLine(number);
    }
}
catch (Exception e)
{
    Console.WriteLine("Файл не может быть прочтен:");
    Console.WriteLine(e.Message);
}