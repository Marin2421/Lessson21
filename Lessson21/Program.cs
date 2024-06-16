//Урок 3/4
//Тема 21. Работа с файловой системой. Домашнее
//задание. Для двух уроков
//string currentDirectory = @"D:\CS\Projects\Projects\FileWork\FileWork\bin\Debug\net8.0";
//string userInput;

//do
//{
//    Console.WriteLine("Current Directory: " + currentDirectory);
//    Console.Write("Введите название папки для перехода (или 'выход' для завершения): ");
//    userInput = Console.ReadLine();

//    if (userInput.ToLower() == "exit")
//    {
//        break;
//    }

//    // Assume the user input is the new directory name
//    currentDirectory += "\\" + userInput;

//} while (true);

//Урок 4/4
//using System.IO;
//Console.WriteLine("Добро пожаловать в программу удаления файлов и папок!");

//Console.Write("Введите путь к файлу или папке для удаления: ");
//string path = Console.ReadLine();
//if (File.Exists(path) || Directory.Exists(path))
//{
//    Console.Write("Вы уверены, что хотите удалить файл/папку по указанному пути? (Да/Нет): ");
//    string confirmation = Console.ReadLine();

//    if (confirmation.ToLower() == "да")
//    {
//        try
//        {
//            if (File.Exists(path))
//            {
//                File.Delete(path);
//                Console.WriteLine("Файл успешно удален.");
//            }
//            else if (Directory.Exists(path))
//            {
//                Directory.Delete(path, true);
//                Console.WriteLine("Папка успешно удалена.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Произошла ошибка: " + ex.Message);
//        }
//    }
//    else
//    {
//        Console.WriteLine("Удаление отменено пользователем.");
//    }
//}
//else
//{
//    Console.WriteLine("Указанный файл или папка не существует.");
//}
//Тема 22. Блоки try/catch/finally. Домашнее задание.
Console.WriteLine("Введите список чисел, разделенных пробелами:");
string input = Console.ReadLine();

try
{
    string[] numbers = input.Split(' ');
    int sum = 0;

    foreach (string number in numbers)
    {
        if (!string.IsNullOrWhiteSpace(number))
        {
            int num = int.Parse(number);
            sum += num;
        }
    }

    Console.WriteLine("Сумма введенных чисел: " + sum);
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: Введен некорректный формат числа.");
}
catch (Exception ex)
{
    Console.WriteLine("Произошла ошибка: " + ex.Message);
}