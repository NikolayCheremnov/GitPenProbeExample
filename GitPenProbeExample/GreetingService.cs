using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPenProbeExample
{
    public class GreetingService
    {
        private Dictionary<string, string> greetings;

        public GreetingService()
        {
            greetings = new Dictionary<string, string>
        {
            { "en", "Hello" },
            { "ru", "Привет" },
            { "fr", "Bonjour" },
            { "es", "Hola" },
            { "de", "Hallo" },
            { "ko", "안녕하세요" }
        };
        }

        public string GetGreeting(string locale)
        {
            if (greetings.TryGetValue(locale, out string? greeting))
            {
                return greeting;
            }
            else
            {
                return "Извините, я не знаю такую локаль.";
            }
        }
    }
}
