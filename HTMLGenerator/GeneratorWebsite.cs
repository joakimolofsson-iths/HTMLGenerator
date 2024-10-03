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
                _courseList.Add(Utilities.HandleNullAndEmpty(course));
            }
        }

        public void AddMessages(params string[] messages)
        {
            foreach (string message in messages)
            {
                _messageList.Add(Utilities.HandleNullAndEmpty(message));
            }
        }

        protected virtual string PrintHead(string color)
        {
            return "\n<!DOCTYPE html> \n" +
                "<html> \n" +
                "<head> \n" +
                "<style> \n" +
                $"p {{ color: {color} }} \n" +
                "</style> \n" +
                "</head> \n" +
                "<body> \n" +
                $"<h1>Välkomna {ClassName}!</h1>";
        }

        public override string ShowHTML()
        {
            StringBuilder html = new StringBuilder();

            html.AppendLine(PrintHead("black"));            

            for (int i = 0; i < _messageList.Count; i++)
            {
                html.AppendLine($"<p>Meddelande {i + 1}: {StyleString(_messageList[i])}</p>");
            };

            html.AppendLine($"<main>");

            for (int i = 0; i < _courseList.Count; i++)
            {
                html.AppendLine($"<p>Kurs om {StyleString(_courseList[i])}</p>");
            };

            html.AppendLine(
                "</main> \n" +
                "</body> \n" +
                "</html>"
            );

            return html.ToString();
        }

        protected string StyleString(string input)
        {
            return char.ToUpper(input.Trim().ToLower()[0]) + input.Trim().ToLower().Substring(1);
        }
    }
}
