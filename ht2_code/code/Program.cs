using System.Text.RegularExpressions;
//Немного не по заданию, хотел адаптировать для любого текста
Console.WriteLine("Введите текст без абзацев");// В консоль почему-то не вставляется с абзацами
string text = Console.ReadLine();
Console.WriteLine("Введите слово, которое хотите найти");
string word = Console.ReadLine();

Regex rx = new Regex(word,RegexOptions.Compiled | RegexOptions.IgnoreCase);

MatchCollection matches = rx.Matches(text);
int nummber = matches.Count;
Console.WriteLine(nummber);