using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    internal class StyledWebsiteGenerator : WebsiteGenerator
    {
        private string PrimaryColor { get; }

        public StyledWebsiteGenerator(string className, string primaryColor)
            : base(className)
        {
            PrimaryColor = primaryColor;
        }

        protected override void PrintHead(string color)
        {
            base.PrintHead(PrimaryColor.ToLower());
        }
    }
}
