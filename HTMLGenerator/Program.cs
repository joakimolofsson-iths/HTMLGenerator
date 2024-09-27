using System.Diagnostics;

namespace HTMLGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebsiteGenerator myWebsite = new WebsiteGenerator();
            myWebsite.HandleInput();
            myWebsite.GenerateHTML();
        }

        class WebsiteGenerator
        {
            public string className;
            public List<string> messages = new List<string>();
            public string[] courses = { " C#", "daTAbaser", "WebbuTVeCkling ", "clean Code " };

            public void HandleInput()
            {
                Console.WriteLine("What is the name of the class?");
                className = HandleNullAndEmpty(Console.ReadLine());

                int msgAmount = 3;
                for (int i = 0; i < msgAmount; i++)
                {
                    Console.WriteLine($"Type message {i + 1} to the class:");
                    messages.Add($"{HandleNullAndEmpty(Console.ReadLine())}");
                }
            }

            public void GenerateHTML()
            {
                Console.WriteLine(
                    $"\n<!DOCTYPE html> \n" +
                    $"<html> \n" +
                    $"<body> \n" +
                    $"<h1>Välkomna {className}!</h1>"
                );
                for (int i = 0; i < messages.Count; i++)
                {
                    Console.WriteLine($"<p>Meddelande {i + 1}: {messages[i]}</p>");
                };
                Console.WriteLine(
                    $"<main> \n" +
                    $"<p>Kurs om {char.ToUpper(courses[0].Trim().ToLower()[0]) + courses[0].Trim().ToLower().Substring(1)}</p> \n" +
                    $"<p>Kurs om {char.ToUpper(courses[1].Trim().ToLower()[0]) + courses[1].Trim().ToLower().Substring(1)}</p> \n" +
                    $"<p>Kurs om {char.ToUpper(courses[2].Trim().ToLower()[0]) + courses[2].Trim().ToLower().Substring(1)}</p> \n" +
                    $"<p>Kurs om {char.ToUpper(courses[3].Trim().ToLower()[0]) + courses[3].Trim().ToLower().Substring(1)}</p> \n" +
                    $"</main> \n" +
                    $"</body> \n" +
                    $"</html>"
                );
            }

            static string HandleNullAndEmpty(string? userInput)
            {
                while (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Invalid input, try something else!");
                    userInput = Console.ReadLine();
                }

                return userInput;
            }
        }
    }
}
