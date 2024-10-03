using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    class GeneratorWebsite : Generator
    {
        public string ClassName { get; private set; }
        private List<string> _courseList;
        private List<string> _messageList;

        public GeneratorWebsite(string className)
        {
            ClassName = className;
            _courseList = new List<string>();
            _messageList = new List<string>();
        }

        public void AddCourses(params string[] courses)
        {
            foreach (string course in courses)
            {
                _courseList.Add(UtilitiesInput.HandleNullAndEmpty(course));
            }
        }

        public void AddMessages(params string[] messages)
        {
            foreach (string message in messages)
            {
                _messageList.Add(UtilitiesInput.HandleNullAndEmpty(message));
            }
        }

        protected virtual void PrintHead(string color)
        {
            Console.WriteLine(
                "\n<!DOCTYPE html> \n" +
                "<html> \n" +
                "<head> \n" +
                "<style> \n" +
                $"p {{ color: \"{color}\" }} \n" +
                "</style> \n" +
                "</head> \n" +
                "<body> \n" +
                $"<h1>Välkomna {ClassName}!</h1>"
            );
        }

        public override void ShowHTML()
        {
            PrintHead("black");

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
                "</main> \n" +
                "</body> \n" +
                "</html>"
            );
        }

        protected string StyleString(string input)
        {
            return char.ToUpper(input.Trim().ToLower()[0]) + input.Trim().ToLower().Substring(1);
        }
    }
}
