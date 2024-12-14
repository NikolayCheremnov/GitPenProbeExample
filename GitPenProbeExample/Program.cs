// Словарь для хранения приветствий на разных языках
var greetings = new Dictionary<string, string>
{
    { "en", "Hello" },
    { "ru", "Привет" },
    { "fr", "Bonjour" },
    { "es", "Hola" },
    { "de", "Hallo" }
};

string? input;
do
{
    Console.Write("Введите код локали (например, en, ru) или 'exit' для выхода: ");
    string locale = Console.ReadLine()?.ToLower() ?? string.Empty;

    if (locale == "exit")
    {
        break;
    }

    if (greetings.TryGetValue(locale, out string? greeting))
    {
        Console.WriteLine($"{greeting}!");
    }
    else
    {
        Console.WriteLine("Извините, я не знаю такую локаль.");
    }

    Console.Write("Хотите попробовать еще раз? (да/нет): ");
    input = Console.ReadLine()?.ToLower();
} while (input == "да");

Console.WriteLine("Программа завершена.");
