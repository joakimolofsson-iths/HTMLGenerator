using System.Diagnostics;

namespace HTMLGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebsiteGenerator website1 = new WebsiteGenerator(".Net");
            website1.AddCourses(" C#", "daTAbaser", "WebbuTVeCkling ", "clean Code ");
            website1.AddMessages(" Möte på måndag", "diskA Koppar", "Sal byte på tisdag ", "Clean Code lektion");
            website1.ShowHTML();

            WebsiteGenerator website2 = new WebsiteGenerator("Javscript");
            website2.AddCourses(" Javascript", "CSS", "WebbuTVeCkling ", "Ramverk ");
            website2.AddMessages(" Möte på tisdag", "CSS style", "Sal byte på tisdag ", "Clean Code lektion tillsammans med .Net");
            website2.ShowHTML();
        }

        class WebsiteGenerator
        {
            public string ClassName { get; }
            private List<string> _courseList;
            private List<string> _messageList;

            public WebsiteGenerator(string className)
            {
                ClassName = className;
                _courseList = new List<string>();
                _messageList = new List<string>();
            }

            public void AddCourses(params string[] courses)
            {
                foreach (string course in courses)
                {
                    _courseList.Add(HandleNullAndEmpty(course));
                }
            }

            public void AddMessages(params string[] messages)
            {
                foreach (string message in messages)
                {
                    _messageList.Add(HandleNullAndEmpty(message));
                }
            }

            public void ShowHTML()
            {
                Console.WriteLine(
                    $"\n<!DOCTYPE html> \n" +
                    $"<html> \n" +
                    $"<body> \n" +
                    $"<h1>Välkomna {ClassName}!</h1>"
                );

                for (int i = 0; i < _messageList.Count; i++)
                {
                    Console.WriteLine($"<p>Meddelande {i + 1}: {StyleString(_messageList[i])}</p>");
                };

                Console.WriteLine($"<main>");
                
                for (int i = 0; i < _courseList.Count; i++)
                {
                    Console.WriteLine($"<p>Kurs om {StyleString(_courseList[i])}</p>");
                };

                Console.WriteLine(
                    $"</main> \n" +
                    $"</body> \n" +
                    $"</html>"
                );
            }

            public string StyleString(string input)
            {
                return char.ToUpper(input.Trim().ToLower()[0]) + input.Trim().ToLower().Substring(1);
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
