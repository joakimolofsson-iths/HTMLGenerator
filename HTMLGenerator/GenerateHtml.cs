﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    internal class GenerateHtml
    {
        private IHtml _website;

        public GenerateHtml(IHtml website)
        {
            _website = website;
        }

        public void RenderHtml()
        {
            Console.WriteLine(_website.PutTogetherHtmlElements());
        }
    }
}