using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    internal interface IHtml
    {
        void AddCourses(params string[] courses);
        void AddMessages(params string[] messages);
        string AddStyling(string color);
        string PutTogetherHtmlElements();
    }
}
