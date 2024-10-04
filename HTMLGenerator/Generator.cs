using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    internal class Generator
    {
        private IWebsite _website;

        public Generator(IWebsite website)
        {
            _website = website;
        }

        public void RenderHtml()
        {
            Console.WriteLine(_website.PutTogetherHtmlElements());
        }
    }
}