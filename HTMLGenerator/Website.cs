using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    class Website : IWebsite
    {
        public string ClassName { get; private set; }
        private List<string> _courseList;
        private List<string> _messageList;

        public Website(string className)
        {
            ClassName = className;
            _courseList = new List<string>();
            _messageList = new List<string>();
        }

        public void AddCourses(params string[] courses)
        {
            _courseList.AddRange(courses.Select(course => Utilities.HandleNullAndEmpty(course)));
        }

        public void AddMessages(params string[] messages)
        {
            _messageList.AddRange(messages.Select(message => Utilities.HandleNullAndEmpty(message)));
        }

        public virtual string AddStyle(string color = "black")
        {
            return "<style>\n" +
                "* {margin: 0; padding: 0; box-sizing: border-box; font-family: sans-serif;}\n" +
                $"p {{font-size: 16px; color: {color}}}\n" +
                "</style>";
        }

        public string PutTogetherHtmlElements()
        {
            StringBuilder html = new StringBuilder();

            html.AppendLine(
                "<!DOCTYPE html> \n" +
                "<html> \n" +
                "<head>"
            );

            html.AppendLine(
                AddStyle()
            );

            html.AppendLine(
                "</head> \n" +
                "<body> \n" +
                $"<h1>Välkomna {ClassName}!</h1>"
            );

            for (int i = 0; i < _messageList.Count; i++)
            {
                html.AppendLine(
                    $"<p>Meddelande {i + 1}: {StyleString(_messageList[i])}</p>"
                );
            };

            html.AppendLine(
                "<main>"
            );

            for (int i = 0; i < _courseList.Count; i++)
            {
                html.AppendLine(
                    $"<p>Kurs om {StyleString(_courseList[i])}</p>"
                );
            };

            html.AppendLine(
                "</main> \n" +
                "</body> \n" +
                "</html>"
            );

            return html.ToString();
        }

        private string StyleString(string input)
        {
            return char.ToUpper(input.Trim().ToLower()[0]) + input.Trim().ToLower().Substring(1);
        }
    }
}
