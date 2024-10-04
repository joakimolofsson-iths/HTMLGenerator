using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    internal interface IWebsite
    {
        void AddCourses(params string[] courses);
        void AddMessages(params string[] messages);
        string AddStyle(string color);
        string PutTogetherHtmlElements();
    }
}
