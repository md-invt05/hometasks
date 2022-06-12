using System;
using System.IO;
while (true)   //основной метод
{
    try
    {
        Console.WriteLine("Введите название файла и его тип(пример: test.txt)");
        string name = Console.ReadLine();
        var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
        var path = Path.GetDirectoryName(location);
        path = path + "/" + name;
        FileInfo file = new FileInfo(path);
        Console.WriteLine("введите текст");
        string text = Console.ReadLine();
        StreamWriter sw = file.CreateText();
        sw.WriteLine(text);
        sw.Close();
        Console.WriteLine($"Полное имя файла: {file.FullName}");
        Console.WriteLine($"Дата создания: {file.CreationTime}");
        Console.WriteLine($"Дата последнего доступа: {file.LastAccessTime}");
        Console.WriteLine($"Дата последней записи в файл: {file.LastWriteTime}");
        Console.WriteLine($"Размер файла: {file.Length} byte");
        Console.WriteLine($"Имя файла: {file.Name}");
        return;
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Exception: {ex.Message}");
        Console.ResetColor();
    }
}