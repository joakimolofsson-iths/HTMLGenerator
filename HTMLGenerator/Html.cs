using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    class Html : IHtml
    {
        public string ClassName { get; private set; }
        public virtual string Color { get; private set; } = "black";

        private List<string> _courseList;
        private List<string> _messageList;

        public Html(string className)
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

        public virtual string AddStyling(string color)
        {
            Color = Utilities.HandleNullAndEmpty(color.ToLower());
            return "* {margin: 0; padding: 0; box-sizing: border-box; font-family: sans-serif;}\n" +
                $"p {{font-size: 16px; color: {Color}}}";
        }

        public string PutTogetherHtmlElements()
        {
            StringBuilder html = new StringBuilder();

            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html>");
            html.AppendLine("<head>");
            html.AppendLine("<style>");
            html.AppendLine(AddStyling(Color));
            html.AppendLine("</style>");
            html.AppendLine("</head>");
            html.AppendLine("<body>");
            html.AppendLine($"<h1>Välkomna {ClassName}!</h1>");

            for (int i = 0; i < _messageList.Count; i++)
            {
                html.AppendLine($"<p>Meddelande {i + 1}: {StyleString(_messageList[i])}</p>");
            };

            html.AppendLine("<main>");

            for (int i = 0; i < _courseList.Count; i++)
            {
                html.AppendLine($"<p>Kurs om {StyleString(_courseList[i])}</p>");
            };

            html.AppendLine("</main>");
            html.AppendLine("</body>");
            html.AppendLine("</html>");

            return html.ToString();
        }

        private string StyleString(string input)
        {
            return char.ToUpper(input.Trim().ToLower()[0]) + input.Trim().ToLower().Substring(1);
        }
    }
}
