// Словарь для хранения приветствий на разных языках
var greetings = new Dictionary<string, string>
{
    { "en", "Hello" },
    { "ru", "Привет" },
    { "fr", "Bonjour" },
    { "es", "Hola" },
    { "de", "Hallo" }
};

Console.Write("Введите код локали (например, en, ru): ");
string locale = Console.ReadLine()?.ToLower() ?? string.Empty;

if (greetings.TryGetValue(locale, out string? greeting))
{
    Console.WriteLine($"{greeting}!");
    return;
}
Console.WriteLine("Извините, я не знаю такую локаль.");
