using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPenProbeExample
{
    public class UserInterface
    {
        private GreetingService greetingService;

        public UserInterface(GreetingService greetingService)
        {
            this.greetingService = greetingService;
        }

        public void Run()
        {
            string? input;
            do
            {
                Console.Write("Введите код локали (например, en, ru) или 'exit' для выхода: ");
                string locale = Console.ReadLine()?.ToLower() ?? string.Empty;

                if (locale == "exit")
                {
                    break;
                }

                string greeting = greetingService.GetGreeting(locale);
                Console.WriteLine($"{greeting}!");

                Console.Write("Хотите попробовать еще раз? (да/нет): ");
                input = Console.ReadLine()?.ToLower();
            } while (input == "да");

            Console.WriteLine("Программа завершена.");
        }
    }
}
