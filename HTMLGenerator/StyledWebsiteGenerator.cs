using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLGenerator
{
    internal class StyledWebsiteGenerator : WebsiteGenerator
    {
        private string _color;

        public StyledWebsiteGenerator(string className)
            : base(className)
        {
            
        }

        public string Color
        {
            get => _color;
            set => _color = InputUtilities.HandleNullAndEmpty(value);
        }

        protected override void PrintHead(string color)
        {
            base.PrintHead(_color.ToLower());
        }
    }
}
